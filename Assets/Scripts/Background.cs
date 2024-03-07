using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    private float moveSpeed = 3f;
    // Update is called once per frame
    void Update()
    {
        // Move the background down
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if(transform.position.y < -10f)
        {
            transform.position = new Vector3(transform.position.x, 10f, transform.position.z);
        }
           
    }
}
