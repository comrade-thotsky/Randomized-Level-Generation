using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public Transform playerTransform;
    public CameraScript camera;
    // Start is called before the first frame update
    void Start()
    {
        camera.setup(() => playerTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
