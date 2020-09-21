using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliControler : MonoBehaviour
{
    private NPCTipControler NPCTip;
    private GameObject NPC;
    protected virtual void Start() {
        NPCTip = gameObject.transform.parent.GetChild(0).GetComponent<NPCTipControler>();
    }
    protected virtual void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            NPCTip.Display();
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            NPCTip.Hide(); 
        }
    }
}
