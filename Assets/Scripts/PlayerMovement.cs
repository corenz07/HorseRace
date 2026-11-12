using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.2f;

    [SerializeField] private Rigidbody rbPlayer;

    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayer.AddForce(-speed, 0.0f, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rbPlayer.AddForce(speed, 0.0f, speed);
        }
    }
}
