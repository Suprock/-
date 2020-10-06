using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Button bBegin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButtonBegin()
    {
        PlayerPrefs.SetString("MASK", "0");
        GameDataCache dtc = new GameDataCache();
        dtc.sceneID = 1;
        dtc.money = 0;
        dtc.LP.Add(JsonUtility.FromJson<PlayerProperty>(PlayerProperties.sNezha));
        PlayerPrefs.SetString("gamedatacache", JsonUtility.ToJson(dtc));
        SceneManager.LoadSceneAsync(1);
    }

    public void OnClickButtonLoad()
    {
        PlayerPrefs.SetString("MASK", "1");
        //读取json文件，写入缓存文件
    }
}
