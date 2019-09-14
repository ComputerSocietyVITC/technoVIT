using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forhello : MonoBehaviour
{
    public int rec;
    Rigidbody rg;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        rec = 0;    
    }
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
        if (rec == 1)
        {
            rg.isKinematic = true;
        }
    }

}
