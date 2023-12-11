using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Collected : MonoBehaviour
{
    Collider2D colider;
    public PlayerHealth pHealth;
    public float damage;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().health += damage;
            Debug.Log("trigger entered");
        }
    }
   
}
