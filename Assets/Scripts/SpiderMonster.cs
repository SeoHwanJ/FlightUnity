using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMonster : MonoBehaviour
{
 [SerializeField]
    private float moveSpeed =10f;

    private float minY = -7f;
    
   [SerializeField]
    private float hp =1f;

    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if(transform.position.y < minY)
        {
            Destroy(gameObject);
        }   
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Weapon")
        {
            Debug.Log("Weapon");
            WebShooter weapon = other.gameObject.GetComponent<WebShooter>();
            if(weapon != null)
            {
                hp -= weapon.damage;    
                if(hp <= 0)
                {
                    Destroy(gameObject);
                }
            }
            Destroy(other.gameObject);
        }
    }
    
}
