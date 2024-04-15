using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float speed;

    private Vector3 rotate;

   void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()
    {
        Rotate();
        transform.position = player.position + offset;
        transform.LookAt(player.transform.position);
    }

    void Rotate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*4f, Vector3.up) * offset;
    }
}
