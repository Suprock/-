using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestControler : MonoBehaviour
{
    // Start is called before the first frame update
    bool isPlayerNear;
    void Start()
    {
        
    }
    private void OnGUI() {
        if(PlayerPrefs.GetString("宝箱1") == "opened")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("/Articles/物品29");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerNear)
            GetInput();

    }

    public void Open()
    {
        if(PlayerPrefs.GetString("宝箱1") == "opened")
        {
            print("箱子已经被打开了！");
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("/Articles/物品29");
            PlayerPrefs.SetString("宝箱1", "opened");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            print("察觉到玩家进入");
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            print("察觉到玩家离开");
            isPlayerNear = false;
        }
    }

    void GetInput()
    {
        if(Input.GetKey(KeyCode.F))
        {
            Open();
            print("获得草药+1");
            Item item = JsonUtility.FromJson<Item>(Items.Herb);
            GameDataCache dtc = JsonUtility.FromJson<GameDataCache>(PlayerPrefs.GetString("gamedatacache"));
            int num;
            bool istrue = dtc.dItems.TryGetValue(item, out num);
            if(istrue)
            {
                num += 1;
                
            }
            else
            {
                num = 1;
            }
            dtc.dItems.Add(item, num);
        }
    }
}
