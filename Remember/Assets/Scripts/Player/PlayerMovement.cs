using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Vector2 moveInput;
    private bool isFlip;

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKey(KeyCode.A)) { transform.position -= transform.right * speed * Time.deltaTime; }

        else if (Input.GetKey(KeyCode.D)) { transform.position += transform.right * speed * Time.deltaTime; }

        if (isFlip && moveInput.x > 0)
        {
            Flip();
        }
        else if (!isFlip && moveInput.x < 0)
        {
            Flip();
        }
    }

    private void Flip()
    {
        isFlip = !isFlip;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
