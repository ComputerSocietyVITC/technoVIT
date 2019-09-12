using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platemovement : MonoBehaviour
{
    public float speed = 5f;
    //public float rotspeed = 50f;
    Rigidbody rg;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - transform.position).normalized;
        rg.velocity = new Vector3(direction.x * speed, direction.y * speed);
        /*float sd = Input.GetAxis("Vertical");
        var angles = transform.rotation.eulerAngles;
        angles.z += Time.deltaTime * rotspeed * sd;
        transform.rotation = Quaternion.Euler(angles);*/
    }
}