using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PlayerControler : MonoBehaviour
{
    private Vector2 direction;
    private float speed;
    private Animator anim;
    public AIPath aIPath;
    private Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.zero;
        speed = 0.04f;
        anim = gameObject.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (aIPath.velocity.y >= 0.01f)
        {
            direction = Vector2.up;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
            //Move()y
        }
        else if (aIPath.velocity.y <= -0.01f)
        {
            direction = Vector2.down;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
           // Move();
        }
        else if (aIPath.velocity.x <= -0.01f)
        {
            direction = Vector2.left;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
           // Move();
        }
        else if (aIPath.velocity.x >= 0.01f)
        {
            direction = Vector2.right;
            anim.SetFloat("X", direction.x);
            anim.SetFloat("Y", direction.y);
            //Move();
        }
        // Vector3 newPosition = Vector3.zero;
        // if(Input.GetMouseButtonDown(0))
        // {
        //     newPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        //     newPosition.z = 0;
        //     seeker.StartPath(transform.position, newPosition);
        // }
    }

    void Move()
    {
        transform.Translate(direction * speed);
    }

}
