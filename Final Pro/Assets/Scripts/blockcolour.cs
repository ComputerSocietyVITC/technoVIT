using UnityEngine;

public class blockcolour : MonoBehaviour
{
    Material mat;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changecolour()
    {
        mat = Resources.Load<Material>("mat");
        MeshRenderer rend = GetComponent<MeshRenderer>();
        Material current = rend.material;
        Debug.Log(current.name);
        if(i==1)
        {
            rend.material.color = Color.blue;
            i++;
        }
        if(i==2)
        {
            rend.material.color = Color.yellow;
            i++;
        }
        if(i==3)
        {
            rend.material.color = Color.white;
            i=1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
