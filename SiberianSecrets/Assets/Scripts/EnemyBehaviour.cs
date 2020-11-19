using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //Pathing and Checkpoint variables
    public Transform[] path;
    [Serializable]
    public struct Post
    {
        public Transform waypointLook;
        public float seconds;
    }
    public Post[] posts;

    //Collider & Detection variables
    

    //Control variables
    bool waiting = false;
    public float speed = 1f;
    public float waypointRadius = 0.64f;
    bool forward = true;
    Transform currentWaypoint;
    int currentWaypointIndex;

    private void Start()
    {
        currentWaypoint = path[0];
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, currentWaypoint.position) > waypointRadius && !waiting)
        {
            NavigateWaypoints(currentWaypoint);
        }
        else if (!waiting)
        {
            CheckForPost();
        }
    }

    #region NavigationMethods
    public void NavigateWaypoints(Transform waypoint)
    {
        Debug.Log($"{this.name} is heading to {waypoint.name}");
        var dir = waypoint.transform.position - transform.position;
        transform.position += dir.normalized * Time.deltaTime * speed;
        transform.up = dir.normalized;
    }

    public IEnumerator WaitInPlace(Vector3 dir, float seconds)
    {
        //Debug.Log("Entering coroutine at:" + Time.time);
        transform.up = dir.normalized;
        waiting = true;

        yield return new WaitForSeconds(seconds);
        waiting = false;
        //Debug.Log("Exiting coroutine at:" + Time.time);
    }

    public void CheckForPost()
    {
        Transform previousPoint = currentWaypoint;
        SetNextPoint();
        foreach (Post post in posts)
        {
            if (post.waypointLook.position == previousPoint.position)
            {
                Debug.Log($"{this.name} reached a post, starting idle...");
                var direction = currentWaypoint.position - transform.position;
                StartCoroutine(WaitInPlace(direction, post.seconds));
                break;
            }
        }
    }

    public void SetNextPoint()
    {
        if (currentWaypoint != path[0] && currentWaypoint != path[path.Length - 1])
        {
            if (forward)
            {
                currentWaypointIndex++;
                currentWaypoint = path[currentWaypointIndex];
            }
            else
            {
                currentWaypointIndex--;
                currentWaypoint = path[currentWaypointIndex];
            }
        }
        else
        {
            if(currentWaypoint == path[0])
            {
                currentWaypointIndex++;
                currentWaypoint = path[currentWaypointIndex];
                forward = true;
            }
            else if (currentWaypoint == path[path.Length - 1])
            {
                currentWaypointIndex--;
                currentWaypoint = path[currentWaypointIndex];
                forward = false;
            }
        }
    }
    #endregion
}
