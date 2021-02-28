using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Func<Vector3> GetCameraFollowPosition;

    public void setup(Func<Vector3> GetCameraFollowPosition)
    {
        this.GetCameraFollowPosition = GetCameraFollowPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraFollowPosition = GetCameraFollowPosition();
        cameraFollowPosition.z = transform.position.z;
        transform.position = cameraFollowPosition;
    }
}
