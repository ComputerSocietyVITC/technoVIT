using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Falling_Cap;
    public float spawngap = 1;
    float nxtst;
    public blockcolour bcolour;
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nxtst)
        {
            nxtst = Time.time + spawngap;
            // Vector3 spawnpos = new Vector3(Random.Range(-9, 9), 6, 0);
            Vector3 spawnpos = new Vector3(0,6,0);
            bcolour.changecolour();
            Instantiate(Falling_Cap, spawnpos, Quaternion.identity);
        }
    }

    
}
