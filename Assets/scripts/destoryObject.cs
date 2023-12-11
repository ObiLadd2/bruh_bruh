using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class destoryObject : MonoBehaviour
{
    Rigidbody2D rb;

    public Collected collected;


    private void OnTriggerExit2D(Collider2D collision)
    {
      Destroy (collected.gameObject);
    }


}
