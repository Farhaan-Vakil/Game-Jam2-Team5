using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterMovement : MonoBehaviour
{
    public int speed = 10;

    public Rigidbody2D rb;
  
    public bool isGrounded = false;
    public Vector2 up;

    public Animator animator;

    void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(up, ForceMode2D.Impulse);
            isGrounded = false;
        }
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

    }

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

}
