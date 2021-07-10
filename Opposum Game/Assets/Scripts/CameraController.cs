using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraLag;
    public Transform target;
    public Vector3 offset;
    public Vector3 targetPosition;
    void Start()
    {
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * cameraLag);
    }
}
