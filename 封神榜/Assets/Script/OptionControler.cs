using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Text leftTip;
    public Text nezhaHealth, nezhaMagic, nezhaExp;
    public Text xiaolongnvHealth, xiaolongnvMagic, xiaolongnvExp;
    public Text yangjianHealth, yangjianMagic, yangjianExp;
    public Text jiangziyaHealth, jiangziyaMagic, jiangziyaExp;
    public GameObject pnezha, pxiaolongnv, pyangjian, pjiangziya;

    GameDataCache dtc;
    void Start()
    {
        
    }
    private void Awake() {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }

    public void Show()
    {
        setPropertyUI();
        gameObject.SetActive(true);
    }

    public void setPropertyUI()
    {
        //1. 获取player的属性
        //2. 分析属性中的气血、魔法、经验值
        //3. 设置UI属性
        print("setUI");
        //string datacache = PlayerPrefs.GetString("gamedatacache");
        dtc = JsonUtility.FromJson<GameDataCache>(PlayerPrefs.GetString("gamedatacache"));
        SetPlayerUI(dtc.LP);
    }

    void SetPlayerUI(List<PlayerProperty> lplayers)
    {

        for(int i = 0; i < lplayers.Count; i++)
        {
            if(lplayers[i].name == "nezha")
            {
                
                nezhaHealth.text = lplayers[i].healthValue.ToString() + "/" + lplayers[i].maxHealthValue.ToString();
                nezhaMagic.text = lplayers[i].magicalValue.ToString() + "/" + lplayers[i].maxMagicalValue.ToString();
                nezhaExp.text = lplayers[i].exp.ToString();
                pnezha.SetActive(true);
            }
            else if(lplayers[i].name == "xiaolongnv")
            {
                xiaolongnvHealth.text = lplayers[i].healthValue.ToString() + "/" + lplayers[i].maxHealthValue.ToString();
                xiaolongnvMagic.text = lplayers[i].magicalValue.ToString() + "/" + lplayers[i].maxMagicalValue.ToString();
                xiaolongnvExp.text = lplayers[i].exp.ToString();
                pxiaolongnv.SetActive(true);
            }
            else if(lplayers[i].name == "yangjian")
            {
                yangjianHealth.text = lplayers[i].healthValue.ToString() + "/" + lplayers[i].maxHealthValue.ToString();
                yangjianMagic.text = lplayers[i].magicalValue.ToString() + "/" + lplayers[i].maxMagicalValue.ToString();
                yangjianExp.text = lplayers[i].exp.ToString();
                pyangjian.SetActive(true);
            }
            else if(lplayers[i].name == "jiangziya")
            {
                jiangziyaHealth.text = lplayers[i].healthValue.ToString() + "/" + lplayers[i].maxHealthValue.ToString();
                jiangziyaMagic.text = lplayers[i].magicalValue.ToString() + "/" + lplayers[i].maxMagicalValue.ToString();
                jiangziyaExp.text = lplayers[i].exp.ToString();
                pjiangziya.SetActive(true);
            }
        }
    }
}
