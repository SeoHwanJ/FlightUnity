using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject weapon;
    
    [SerializeField]
    private Transform shootTransform;
    [SerializeField]
    private float shotCooldown = 0.5f;

    public Animator anim;

    // Time since the last shot
    private float timeSinceLastShot = 0f;

    [SerializeField]
    private float animResetTime = 1f;

    private float totalDeltaAnimTime = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        timeSinceLastShot += Time.deltaTime;
        
        if(Input.GetMouseButtonDown(0) && timeSinceLastShot >= shotCooldown)
        {
            int motionIndex = Random.Range(0, 3);
            Debug.Log("Motion Index: " + motionIndex);
            anim.SetInteger("ShotMotion", motionIndex);    
            anim.SetBool("Shot", true);
            Shot();
        }

        if(Input.GetKey(KeyCode.Space) && timeSinceLastShot >= shotCooldown)
        {
            int motionIndex = Random.Range(0, 3);
            Debug.Log("Motion Index: " + motionIndex);
            anim.SetInteger("ShotMotion", motionIndex);    
            anim.SetBool("Shot", true);
            Shot();
            
        }
        
        if(anim.GetBool("Shot") )
        {
            totalDeltaAnimTime += Time.deltaTime;
            if(totalDeltaAnimTime >= animResetTime)
            {
                Debug.Log("Resetting anim");
                anim.SetBool("Shot", false);
                totalDeltaAnimTime = 0f;
            }
           
        }
    }

    void Shot()
    {
        Debug.Log("Shot");
        Instantiate(weapon, shootTransform.position, Quaternion.identity);
        timeSinceLastShot = 0f;

    }
}
