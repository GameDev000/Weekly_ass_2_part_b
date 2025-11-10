using UnityEngine;

public class MapMove : MonoBehaviour
{
     public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(0.3f, 0, 0) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(-0.3f, 0, 0) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0, 0.3f, 0) * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += new Vector3(0, -0.3f, 0) * speed * Time.deltaTime;

    }
}
