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
    private int mask;
    void Start()
    {
        direction = Vector2.zero;
        speed = 0.04f;
        anim = gameObject.GetComponent<Animator>();
        //接受开始或者读档场景传递的数据
        //读档数据要把属性都传递过来。json数据以mask为标准判定是读档或是新的开始
        //如{"mask":1, "archive":1}
        //如{"mask":0}
        mask = 0;
        if(mask == 0)
        {
            PlayerProperty playerNezha = new PlayerProperty("nezha");
            playerNezha.InitZeroProperty();
        }
        else if(mask == 1)
        {
            //根据archive内容设置不同主角信息
        }
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
