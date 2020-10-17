using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

public class NPCGiving : MonoBehaviour
{
    public GameObject gbPanel;
    public Text text;
    public Transform transformTarget;

    static string tip = "箱子已经被打开了！";

    static float waitTime = 0.2f;
    bool isRunning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YinfurenGiving()
    {
        if(PlayerPrefs.GetInt("jq_yinfuren") != 1)
        {
            GameDataCache dtc = JsonUtility.FromJson<GameDataCache>(PlayerPrefs.GetString("gamedatacache"));
            dtc.money += 100;
            PlayerPrefs.SetString("gamedatacache", JsonUtility.ToJson(dtc));
            print("你获得了金钱+100！");
            StartCoroutine(SetTextLable("你获得了金钱+100！"));
            PlayerPrefs.SetInt("jq_yinfuren", 1);
        }
        
    }

    IEnumerator SetTextLable(string str)
    {
        isRunning = true;
        text.text = "";
        transformTarget.gameObject.GetComponent<TargetMover>().enabled = false;
        gbPanel.SetActive(true);
        for(int i = 0; i < str.Length; i++)
        {
            text.text += str[i];
            yield return new WaitForSeconds(waitTime);
        }
        for(int i = 0; i <= 2; i++)
        {
            yield return new WaitForSeconds(waitTime);
        }
        transformTarget.gameObject.GetComponent<TargetMover>().enabled = true;
        gbPanel.SetActive(false);
        isRunning = false;
    }
}
