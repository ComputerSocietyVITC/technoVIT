using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiona : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Destroy (gameObject);
        print("Hello");
    }
}

