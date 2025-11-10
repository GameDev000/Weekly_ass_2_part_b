using UnityEngine;

public class CameraAutoSize : MonoBehaviour
{
    private Camera cam;
    private float res = 16f / 9f;
    private float size = 5f; 
    
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.orthographic = true;
    }

    void Update()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        cam.orthographicSize = size * (res / currentAspect);
    }
}
