using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private float movementX;
    private float movementY;
    public float speed = 1;

    public float moveSpeed = 10f;

    public bool isGrounded = false;
    public Vector2 up;



    private void Start()
    {
        up = new Vector2(0f, 10f);
    }
    void OnCollisionStay2D()
    {
        isGrounded = true;
    }

    void OnCollisionExit2D()
    {
        isGrounded = false;
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(up, ForceMode2D.Impulse);
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Camera.main.transform);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Camera.main.transform);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-Vector3.right * Time.deltaTime * moveSpeed, Camera.main.transform);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime, Camera.main.transform);


    }
}
