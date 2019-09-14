using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlebehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    static float rec;
    Rigidbody rg;
    float speed = 100f;
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
        }
        if (rec == 1)
        {
            rg.isKinematic = true;
        }
    }
}
