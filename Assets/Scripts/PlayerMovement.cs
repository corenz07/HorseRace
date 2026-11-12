using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.2f;

    [SerializeField] private Rigidbody rbPlayer;

    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayer.AddForce(-speed, 0.0f, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rbPlayer.AddForce(speed, 0.0f, speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rbPlayer.AddForce(0.0f, 20.0F, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rbPlayer.AddForce(0.0f, -20.0F, 0.0f);
        }
    }
}
