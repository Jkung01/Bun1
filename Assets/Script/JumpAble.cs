using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAble : MonoBehaviour
{
    [SerializeField] private float jumpForce = 20f;

    public float xAngle, yAngle, zAngle;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            Debug.Log("Jump");
            Rigidbody2D rigidbody = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        else if (collision.CompareTag("Spike"))
        {
            Debug.Log("You are dead");
            Rigidbody2D rigidbody = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            rigidbody.transform.Rotate(90f, 0.0f, 0.0f, Space.Self);
        }

    }
}
