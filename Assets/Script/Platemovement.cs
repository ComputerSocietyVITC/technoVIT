using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platemovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotspeed = 50f;
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

        Vector2 mv = new Vector2(mh, 0f);
        rg.AddForce(mv * speed);
        float sd = Input.GetAxis("Vertical");
        var angles = transform.rotation.eulerAngles;
        angles.z += Time.deltaTime * rotspeed * sd;
        transform.rotation = Quaternion.Euler(angles);
    }
}