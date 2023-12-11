using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public int spawn;
    public float health = 100;
    public float maxHealth = 100;
    public Image healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health);
        healthbar.fillAmount = Mathf.Clamp (health / maxHealth, 0.0f, 1.0f);
        if (health > maxHealth ) health = maxHealth;
        
        
           
    }
    private void Dead()
    {
        if (health <= 0.0f && CompareTag("Player"))
        {
            SceneManager.LoadScene(spawn);
        }
    }
}