using UnityEngine;
using UnityEngine.InputSystem;

public class MapMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private InputAction moveAction;
    [SerializeField] private float factor = 0.28f;

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
    }

    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        Vector3 movement = new Vector3(input.x * factor, input.y * factor, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
