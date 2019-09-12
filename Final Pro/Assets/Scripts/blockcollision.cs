using UnityEngine;
using UnityEngine.SceneManagement;

public class blockcollision : MonoBehaviour
{
    public Transform block;
    void Update()
    {
        if(block.position.y < -10)
        {
            Debug.Log("Out of screen");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void OnCollisionEnter(Collision colinfo)
    {

    }
}
