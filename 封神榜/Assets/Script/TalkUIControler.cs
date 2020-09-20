using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkUIControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        //1.继续播放剧情
        //2.结束退出
    }
}
