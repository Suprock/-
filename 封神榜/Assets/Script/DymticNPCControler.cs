﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DymticNPCControler : MonoBehaviour
{
    private Vector2 direction;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.left;
        speed = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //Debug.Log(direction.ToString());
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void TurnAround(Vector2 ldirection)
    {
        if(ldirection == Vector2.left)
        {
            gameObject.transform.GetComponent<SpriteRenderer>().flipX = true;
            direction = Vector2.right;
        }
        else if(ldirection == Vector2.right)
        {
            gameObject.transform.GetComponent<SpriteRenderer>().flipX = false;
            direction = Vector2.left;
        }
        
    }
}
