using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float walkSpeed;
    private Vector3 input;
    [SerializeField] private GameObject cam;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");
        var forwardDirection = cam.transform.forward;
        var rightDirection = cam.transform.right;
        forwardDirection.y = 0f;
        rightDirection.y = 0f;
        forwardDirection.Normalize();
        rightDirection.Normalize();
        Vector3 moveDirection = (forwardDirection * input.z) + (rightDirection * input.x);
        transform.Translate(moveDirection * walkSpeed * Time.deltaTime, Space.World);
    }

}
