using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private InputAction moveAction;
    [SerializeField] private Camera cam;
    [SerializeField] private float padding = 0.5f;

    private void OnEnable()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    void Start()
    {
        if (cam == null)
            cam = Camera.main;

        transform.position = Vector3.zero;
    }

    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        Vector3 movement = new Vector3(input.x, input.y, 0f);
        transform.position += movement * speed * Time.deltaTime;

        Vector3 min = cam.ViewportToWorldPoint(new Vector3(0, 0, -cam.transform.position.z));
        Vector3 max = cam.ViewportToWorldPoint(new Vector3(1, 1, -cam.transform.position.z));

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, min.x + padding, max.x - padding);
        pos.y = Mathf.Clamp(pos.y, min.y + padding, max.y - padding);
        transform.position = pos;
    }
}
