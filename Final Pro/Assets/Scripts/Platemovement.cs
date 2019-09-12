using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platemovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotspeed = 50f;
    public float offscreen = 11.8f;
    Rigidbody rg;
    
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float mh = Input.GetAxis("Horizontal");

        Vector3 mv = new Vector3(mh,0f,0f);
        rg.AddForce(mv * speed);
        if(transform.position.x < -offscreen)
        {
            transform.position = new Vector3(offscreen, 0f, 0f);
        }
        if (transform.position.x > offscreen)
        {
            transform.position = new Vector3(-offscreen, 0f, 0f);
        }
        float sd = Input.GetAxis("Vertical");
        var angles = transform.rotation.eulerAngles;
        angles.z += Time.deltaTime * rotspeed * sd;
        transform.rotation = Quaternion.Euler(angles);
    }
    /*Vector3 roti = new Vector3(0, Input.GetAxis("Z"), 0);
    transform.Rotate(roti * rotspeed * Time.deltaTime);*/
}
