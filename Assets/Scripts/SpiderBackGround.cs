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
        if(transform.position.x <= -18.09f)
        {
            transform.position = new Vector3(18.09f, transform.position.y, transform.position.z);
        }
           
    }
}
