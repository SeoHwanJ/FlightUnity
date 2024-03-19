using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject weapon;
    
    [SerializeField]
    private Transform shootTransform;

    [SerializeField]
    private float shootInterval = 0.05f;

    private float lastShootTime = 0f;
    //private float moveSpeed = 5f;
    // Update is called once per frame
    void Start()
    {
        Debug.Log("Player Start");
    }
    void Update()
    {

        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // float verticalInput = Input.GetAxisRaw("Vertical");
        // Vector3 moveTo = new Vector3(horizontalInput, 0, 0);
        // transform.Translate(moveTo * moveSpeed * Time.deltaTime);

        // Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0, 0);

        // if(Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.Translate(-moveTo);
        // }
        // else if(Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.Translate(moveTo);
        // }

        //mouse 
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f);
        transform.position = new Vector3(toX, transform.position.y, transform.position.z);

        shoot();

    }

    void shoot()
    {
        if(Time.time - lastShootTime > shootInterval)
        {
            Instantiate(weapon, shootTransform.position, Quaternion.identity);
            lastShootTime = Time.time;
        }

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
        }
    }
}
