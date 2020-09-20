using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Vector2 direction;
    private float speed;
    private Animator anim;

    private Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.zero;
        speed = 0.08f;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
            Move();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
            Move();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
            Move();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
            Move();
        }
    }

    void Move()
    {
        transform.Translate(direction * speed);
    }

}
