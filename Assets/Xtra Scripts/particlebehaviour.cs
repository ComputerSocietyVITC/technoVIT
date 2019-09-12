using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlebehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rg;
    float speed = 100f;
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
    }
}
