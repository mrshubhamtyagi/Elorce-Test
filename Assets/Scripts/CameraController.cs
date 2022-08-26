using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Vector3 angle;

    void Start()
    {

    }

    void LateUpdate()
    {
        if (target)
        {
            transform.position = target.position + offset;
            transform.rotation = Quaternion.Euler(angle.x, angle.y, angle.z);
        }
    }
}
