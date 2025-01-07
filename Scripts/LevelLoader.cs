using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LevelExit")
        {
            SceneManager.LoadScene("2_FragnanceShop");
        }
        if (other.tag == "2to3")
        {
            SceneManager.LoadScene("3_Hall");
        }
        if (other.tag == "*to3")
        {
            SceneManager.LoadScene("3_Hall");
        }
        if (other.tag == "to1")
        {
            SceneManager.LoadScene("1_DaeGang");
        }
        if (other.tag == "3to2")
        {
            SceneManager.LoadScene("2_FragnanceShop");
        }
        if (other.tag == "2to4")
        {
            SceneManager.LoadScene("4_DaeGang");
        }
    }
}
