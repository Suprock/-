using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DymticNPCControler : MonoBehaviour
{
    private Vector2 direction;
    private float speed;

    private bool isMove;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.left;
        isMove = true;
        speed = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
            Move();
    }

    void Move()
    {
        //Debug.Log(direction.ToString());
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void StopMove()
    {
        isMove = false;
    }

    public void KeepMove()
    {
        isMove = true;
    }

    public void TurnAround()
    {
        bool filpx = gameObject.transform.GetComponent<SpriteRenderer>().flipX;
        if(!filpx)
        {
            gameObject.transform.GetComponent<SpriteRenderer>().flipX = true;
            direction = Vector2.right;
        }
        else
        {
            gameObject.transform.GetComponent<SpriteRenderer>().flipX = false;
            direction = Vector2.left;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            StopMove();
        }
        else
        {
            TurnAround();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            KeepMove();
        }
    }
}
