using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float sd = Input.GetAxis("Horizontal");
        var angles = transform.rotation.eulerAngles;
        angles.z += Time.deltaTime * speed * sd;
        transform.rotation = Quaternion.Euler(angles);
    }
}
