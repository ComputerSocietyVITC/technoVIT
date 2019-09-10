using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyblock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "hello")
        {
            Destroy(col.gameObject);
            print("Hello");
        }
        else if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            print("You Lose");        }
    }
}
