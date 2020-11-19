using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject playerSprite;
    public PlayerControls controls;
    Vector2 move;
    public float speed = 1f;
    private void Awake()
    {
        controls = new PlayerControls();

        //Movement Input
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        //Pause Input
        controls.Gameplay.Pause.performed += ctx => GameplayManager.Instance.PauseGame();
    }

    private void Update()
    {
        //Movement and Character Rotation
        if (move != Vector2.zero)
        {
            //Debug.Log($"X: {move.x}, Y: {move.y}");
            Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
            this.transform.Translate(m * speed, Space.World);

            //Identified Bugs with Rotation: Angle being returned is 90 degrees short of what it should actually be (adding 90 as a hot fix for now).
            double zValue;
            if (m.x < 0)
            {
                zValue = Math.Atan(Convert.ToDouble(m.y / m.x));
                zValue *= 180 / Math.PI;
                zValue += 90;
            }
            else
            {
                zValue = Math.Atan(Convert.ToDouble(m.y / m.x));
                zValue *= 180 / Math.PI;
                zValue += 270;
            }
            //Debug.Log($"Look Angle: {zValue} degrees");
            playerSprite.transform.eulerAngles = Vector3.forward * Convert.ToSingle(zValue);
        }
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
