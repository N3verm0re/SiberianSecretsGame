using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectionController : MonoBehaviour
{
    Collider2D detectionCollider;
    Collider2D playerCollider;
    public Transform enemyPos;
    Vector3 dir;

    private void Awake()
    {
        detectionCollider = this.GetComponent<Collider2D>();
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
    }

    private void Update()
    {
        dir = playerCollider.GetComponent<Transform>().position - enemyPos.position;
        if (detectionCollider.IsTouching(playerCollider))
        {
            Debug.Log("Player detected in detection collider, casting a ray to check line of sight...");
            if (CanSeePlayer())
            {
                Debug.Log($"Player Caught by {enemyPos.name}");
                //Implement Game Over
            }
            else
            {
                Debug.Log("Player is not within line of sight...");
            }
        }
    }

    bool CanSeePlayer()
    {
        //RaycastHit2D hit = Physics2D.Linecast(enemyPos.position, playerCollider.GetComponentInParent<Transform>().position, 1 << LayerMask.NameToLayer("Physics"));
        RaycastHit2D hit = Physics2D.Raycast(enemyPos.position, dir.normalized, Mathf.Infinity, 1 << LayerMask.NameToLayer("Physics"));
        Debug.DrawRay(enemyPos.position, dir.normalized * 100, Color.green);
        if (hit.transform.CompareTag("Player"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
