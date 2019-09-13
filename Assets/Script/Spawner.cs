using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ob1;
    public GameObject ob2;
    public float spawngap = 5;
    public float x = 7;
    float nxtst;
    public Material white;
    public Material blue;
    public Material yellow;
    public MeshRenderer rendcube;
    public MeshRenderer rendcaps;
    static int i;
    // Start is called before the first frame update
    void Start()
    {
        i=1;
     }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nxtst)
        {
            int no;
            no = Random.Range(1,100);
            nxtst = Time.time + spawngap;
            Vector3 spawnpos = new Vector3(Random.Range(-x, x), 6, 0);
            i = Random.Range(1, 3);
            if(i==1)
            {
                rendcube.material = yellow;
                rendcaps.material = yellow;
                // i++;
            }
            else if(i==2)
            {
                rendcube.material = blue;
                rendcaps.material = blue;
                // i++;
            }
            else if(i==3)
            {
                rendcube.material = white;
                rendcaps.material = white;
                // i=1;
            }

            if (no%2==0)
            {
                Instantiate(ob1, spawnpos, Quaternion.identity);
            }
            else
            {
                Instantiate(ob2, spawnpos, Quaternion.Euler(0, 0, 90));
            }
        }
    }
}

