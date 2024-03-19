using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
     private float minY = -7f;
    void Start()
    {
       Jump(); 
    }

    void Jump()
    {
        float jumpForce = Random.Range(4f,8f);
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        Vector2 jumpVelocity = Vector2.up * jumpForce;
        jumpVelocity.x = Random.Range(-1.5f, 1.5f);
        rigidBody.AddForce(jumpVelocity, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.y < minY)
        {
            Destroy(gameObject);
        }   
    }
}
