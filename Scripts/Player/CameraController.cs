using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float sensitive;
    private Vector2 mouse;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        CameraHandle();
    }
    private void CameraHandle()
    {
        mouse.x += Input.GetAxisRaw("Mouse X");
        mouse.y -= Input.GetAxisRaw("Mouse Y");
        transform.rotation = Quaternion.Euler(mouse.y, mouse.x, 0);
    }
}
