using UnityEngine;

public class CameraAutoSize : MonoBehaviour
{
    [Tooltip("ה-orthographicSize בזמן ייחוס (כשגובה המסך = referenceScreenHeight)")]
    public float referenceOrthoSize = 7f;

    [Tooltip("גובה-מסך ייחוס בפיקסלים. אפשר להשאיר 0 כדי שיילקח אוטומטית בתחילת הריצה.")]
    public int referenceScreenHeight = 0;

    private Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
        cam.orthographic = true;
    }

    void Start()
    {
        if (referenceScreenHeight <= 0)
        {
            referenceScreenHeight = Screen.height;
        }
    }

    void Update()
    {
        cam.orthographicSize = referenceOrthoSize * ((float)Screen.height / referenceScreenHeight);
    }
}
