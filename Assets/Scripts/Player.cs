using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
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

    }
}
