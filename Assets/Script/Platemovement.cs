using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platemovement : MonoBehaviour
{
    static int rec;
    public float speed = 5f;
    public float rotspeed = 50f;
    Rigidbody rg;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        rec = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && rec == 0)
        {
            rec = 1;
        }
        else if (Input.GetMouseButtonDown(1) && rec == 1)
        {
            rg.isKinematic = false;
            rec = 0;
        }
        if (rec == 0)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePosition - transform.position).normalized;
            rg.velocity = new Vector3(direction.x * speed, direction.y * speed);
            float sd = Input.mouseScrollDelta.y;
            var angles = transform.rotation.eulerAngles;
            angles.z += Time.deltaTime * rotspeed * sd;
            transform.rotation = Quaternion.Euler(angles);
        }
        if (rec == 1)
        {
            rg.isKinematic = true;
        }

    }
}