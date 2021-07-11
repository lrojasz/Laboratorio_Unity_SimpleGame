using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float speed = 10f;
    float horizontalSpeed = 2.0f;

    private Rigidbody playerBody;
    
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float xDirection = Input.GetAxisRaw("Horizontal");
        float zDirection = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        transform.position += moveDirection *speed;

        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);

    }

    

}
