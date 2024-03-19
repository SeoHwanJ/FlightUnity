using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBackGround : MonoBehaviour
{
  private float moveSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        // Move the background down
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if(transform.position.x <= -11.66f)
        {
            transform.position = new Vector3(11.59f, transform.position.y, transform.position.z);
        }
           
    }
}
