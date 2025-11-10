using UnityEngine;
using UnityEngine.InputSystem;

public class MapMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private InputAction moveAction;

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
        Vector3 movement = new Vector3(input.x * 0.28f, input.y * 0.28f, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
