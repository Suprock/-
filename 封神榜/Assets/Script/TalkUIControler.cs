using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkUIControler : MonoBehaviour
{
    [Header("UI组件")]
    public Text textLabel;
    public Image faceImage;

    [Header("文本文件")]
    public TextAsset textFile;
    public string[]  textList;
    public int index;

    private float waitTime;
    private bool isTextFinished;
    private Sprite image;
    // Start is called before the first frame update
    void Awake()
    {
        waitTime = 0.1f;
        isTextFinished = true;
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

    public void Display(GameObject obj)
    {
        //根据获取的组件名称查找剧情以及头像
        SetPlot(obj.name);
        index = 0;
        textList = textFile.text.Split('\n');
        SetFaceImage(textList[index]);
        gameObject.SetActive(true);
        StartCoroutine(SetTextLabel());
    }

    public void Hide()
    {
        index = 0;
        gameObject.SetActive(false);
    }
    public void GetInput()
    {
        
        //1.继续播放剧情
        //2.结束退出
        if(Input.GetKeyDown(KeyCode.F) && index == textList.Length)
        {
            Hide();
            return;
        }
        if(Input.GetKeyDown(KeyCode.F) && isTextFinished)
        {
            // textLabel.text = textList[index];
            // index++;
            SetFaceImage(textList[index]);
            StartCoroutine(SetTextLabel());
        }   
        
    }

    IEnumerator SetTextLabel()
    {
        textLabel.text = "";
        isTextFinished = false;
        for(int i = 0; i < textList[index].Length; i++)
        {
            textLabel.text += textList[index][i];
            yield return new WaitForSeconds(waitTime);
        }
        isTextFinished = true;
        index ++;
    }

    void SetFaceImage(string objName)
    {
        string picName = "";
        string avatarPath = "Textures/";
        Texture2D tex;

        switch(objName)
        {
            case "丫鬟甲\r":
            case "丫鬟\r":
                //查找图像并设置图像
                picName = "yahuan";
                tex = Resources.Load(avatarPath + picName) as Texture2D;
                image = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                faceImage.sprite = image;
                index++;
                break;
            case "殷夫人\r":
                //查找图像并设置图像
                picName = "yinfuren";
                tex = Resources.Load(avatarPath + picName) as Texture2D;
                image = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                faceImage.sprite = image;
                index++;
                break;
            case "李靖\r":
                //查找图像并设置图像
                picName = "lijing";
                tex = Resources.Load(avatarPath + picName) as Texture2D;
                image = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                faceImage.sprite = image;
                index++;
                break;
        }
        
    }

    void SetPlot(string objName)
    {
        string plotName= "";
        string plotPath = "Plots/";
        switch(objName)
        {
            case "NPCMum":
                plotName = "plot_yinfuren";
                textFile = Resources.Load(plotPath + plotName) as TextAsset;
                break;
            case "NPC-丫鬟":
                plotName = "plot_yahuan";
                textFile = Resources.Load(plotPath + plotName) as TextAsset;
                break;
            case "NPC-丫鬟甲":
                plotName = "plot_yahuanjia";
                textFile = Resources.Load(plotPath + plotName) as TextAsset;
                break;
            case "NPC-李靖":
                plotName = "plot_lijing";
                textFile = Resources.Load(plotPath + plotName) as TextAsset;
                break;
        }
    }
}
