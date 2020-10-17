using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureChestControler : MonoBehaviour
{
    // Start is called before the first frame update
    bool isPlayerNear;
    public GameObject gbPanel;
    public Text text;
    public Transform transformTarget;

    static string tip = "箱子已经被打开了！";

    static float waitTime = 0.2f;
    bool isRunning;
    void Start()
    {
        isRunning = false;
    }
    private void OnGUI() {
        if(PlayerPrefs.GetString(transform.name) == "opened")
        {
            Texture2D tex = Resources.Load("Articles/boxopen") as Texture2D;
            Sprite image = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 16.0f);
            gameObject.GetComponent<SpriteRenderer>().sprite = image;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerNear && !isRunning)
            GetInput();
    }

    // private void FixedUpdate() {
    //     if(isPlayerNear)
    //         GetInput();
    // }

    public void Open()
    {
        
        if(PlayerPrefs.GetString(transform.name) == "opened")
        {
            StartCoroutine(SetTextLable(tip));
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Articles/boxopen");
            PlayerPrefs.SetString(transform.name, "opened");
            //查找宝箱-物品的关系
            Box box = JsonUtility.FromJson<Box>(Boxs.GetString(transform.name));
            StartCoroutine(SetTextLable(box.GetString()));
            box.Open();
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

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            isPlayerNear = false;
        }
    }

    void GetInput()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Open();                
        }
    }
}
