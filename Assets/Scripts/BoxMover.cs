using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * movement * speed;

        var movementVertical = Input.GetAxis("Vertical");
        transform.position += Vector3.up * movementVertical * speed;
    }
}
