using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D rb;
    BoxCollider2D boxCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            rb.velocity = new Vector2(moveSpeed, 0f);
            transform.localScale = new Vector3(4, transform.localScale.y, transform.localScale.z);
            //GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
           rb.velocity = new Vector2 (-moveSpeed, 0f);
            transform.localScale = new Vector3(-4, transform.localScale.y, transform.localScale.z);
            //GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("Scale A" + transform.localScale);
        transform.localScale = new Vector2(-(Mathf.Sign(transform.localScale.x)), transform.localScale.y);
        //Debug.Log("Scale B" + transform.localScale);
    }
}
