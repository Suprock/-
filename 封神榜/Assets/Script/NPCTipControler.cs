using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTipControler : MonoBehaviour
{

    private TalkUIControler talkUI;
    public GameObject[] talkUIs;
    // Start is called before the first frame update
    void Start()
    {
        talkUI = GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(1).GetComponent<TalkUIControler>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    public void Display()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    void GetInput()
    {
        if(Input.GetKey(KeyCode.F))
        {
            talkUI.Display(transform.parent.gameObject);
            gameObject.SetActive(false);   
        }
    }
}
