using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DymticNPCColliControler : ColliControler
{
    // Start is called before the first frame update
    private NPCTipControler NPCTip;
    private GameObject NPC;
    private bool isTurnAround;
    private Vector2 direction;
    protected override void Start()
    {
        //base.Start();
        NPCTip = gameObject.transform.parent.GetChild(0).GetComponent<NPCTipControler>();
        NPC = gameObject.transform.parent.gameObject;
        //isTurnAround = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            NPCTip.Display();
            //NPC组件停止运动
            NPC.GetComponent<DymticNPCControler>().StopMove();
        }
        else if(other.transform.tag == "Border")
        {
            Debug.Log("碰到墙的是" + gameObject.name);
            //NPC的移动方向反向，图像翻转
            //Debug.Log("碰到墙啦！");
            //Debug.Log(isTurnAround.ToString());
            if(gameObject.name == "leftColli")
            {
                direction = Vector2.left;
            }
            else if(gameObject.name == "rightColli")
            {
                direction = Vector2.right;
            }
            // else if(gameObject.name == "topColli")
            // {
            //     direction = Vector2.up;
            // }
            // else if(gameObject.name == "bottomColli")
            // {
            //     direction = Vector2.down;
            // }
            //gameObject.transform.parent.GetComponentInParent<DymticNPCControler>().TurnAround(direction);
        }
    }

    protected override void OnTriggerExit2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            NPCTip.Hide(); 
            NPC.GetComponent<DymticNPCControler>().KeepMove();
        }
        // else if(other.transform.tag == "Border")
        // {
        //     //NPC的移动方向反向，图像翻转
        //     Debug.Log("离开墙了！");
            
        //     isTurnAround = false;
        // }
    }
}
