using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Falling_Cap;
    public float spawngap = 5;
    public float x = 7;
    float nxtst;
    // Start is called before the first frame update
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nxtst)
        {
            nxtst = Time.time + spawngap;
            Vector3 spawnpos = new Vector3(Random.Range(-x, x), 6, 0);
            Instantiate(Falling_Cap, spawnpos, Quaternion.identity);
        }
    }
}

