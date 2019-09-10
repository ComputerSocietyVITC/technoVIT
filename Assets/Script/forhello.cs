using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forhello : MonoBehaviour
{
    public class prefabulation : MonoBehaviour
    {
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "hello" && gameObject.tag=="Player")
            {
                col.gameObject.tag = "Player";
            }
        }
    }

}
