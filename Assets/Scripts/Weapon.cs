using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveSpeed =10f;

    void Start()
    {
        Debug.Log("Weapon Start");
        Destroy(gameObject, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        
    }
}
