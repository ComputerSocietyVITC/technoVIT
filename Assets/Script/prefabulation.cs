using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class prefabulation : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "hello")
        {
            col.gameObject.tag = "Player";
            print("You Lose");
            
        }
    }
}
