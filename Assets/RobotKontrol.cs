using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RobotKontrol : MonoBehaviour
{

    private Rigidbody rb;
    private Animation anim;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();
    }

    
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 hareket = new Vector3(x, 0, y);
        rb.velocity = hareket * 1f;

        if(x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);

        }
        if(x != 0 || y != 0)
        {
            anim.Play("idle");
        }
       
    
    }
}
