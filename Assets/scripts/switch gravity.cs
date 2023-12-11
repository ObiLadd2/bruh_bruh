using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchgravity : MonoBehaviour
{
    

    public GameObject levelVariant;


    // Start is called before the first frame update
    private void Start()
    {
        if(levelVariant == null)
        {
            print("need to add level variant");
        }
        else
        {
            levelVariant.SetActive(false);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //SceneManager.LoadScene(spawn); // not used

            //find all active levels by tag and setactive false
            GameObject[] gos;
            gos = GameObject.FindGameObjectsWithTag("Level");
            for (int i = 0; i < gos.Length; i++)
            {
                gos[i].SetActive(false);
            }

            //turn on  the next level active
            levelVariant.SetActive(true);
        }
    }
}
