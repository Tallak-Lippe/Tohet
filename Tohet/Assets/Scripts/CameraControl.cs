using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraControl : MonoBehaviour
{
    new Camera camera;
    public static bool _2D = true;

    public Transform transform2D;
    public Transform transform3D;
    public float lerpingSpeed;

    private bool lerping;
    private float lerpProgress;
    private Transform lerpingTarget;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lerping)
        {
            transform.position = Vector3.Lerp(transform.position, lerpingTarget.position, lerpProgress);
            transform.rotation = Quaternion.Lerp(transform.rotation, lerpingTarget.rotation, lerpProgress);

            if(lerpProgress > 1)
                lerping = false;
            
            lerpProgress += lerpingSpeed * Time.deltaTime;
        }
    }

    public void SwithcDimension()
    {
        if (_2D)
        {
            ChangeTo3D();
        }
        else
        {
            ChangeTo2D();
        }
    }

    public void ChangeTo3D()
    {
        camera.orthographic = false;
        lerping = true;
        lerpingTarget = transform3D;
        lerpProgress = 0;
        _2D = false;
    }

    public void ChangeTo2D()
    {
        camera.orthographic = true;
        lerping = true;
        lerpingTarget = transform2D;
        lerpProgress = 0;
        _2D = true;
    }
}


