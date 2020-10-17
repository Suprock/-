using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Item
{
    public enum Type
    {
        //药品
        Drug,
        Material,
        //法宝
        Sutra,
        Common
    }

    public enum PropertyType
    {
        Health,
        Magic,
        Detoxify
    }
    public int ID;
    public string name;
    public Type type;
    public string content;
    public PropertyType pt;
    public int ptNum;
    public int price;
    // Start is called before the first frame update
    // public Item()
    // {

    // }
}

public static class Items
{
    public static string Herb = "{\"ID\":1,\"name\":\"药草\",\"type\":0,\"content\":\"回复生命50\",\"pt\":0,\"ptNum\":50,\"price\":30}";
    public static string Ginseng1 = "{\"ID\":2,\"name\":\"参须\",\"type\":0,\"content\":\"回复生命200\",\"pt\":0,\"ptNum\":200,\"price\":60}";
    public static string Ginseng2 = "{\"ID\":3,\"name\":\"人参\",\"type\":0,\"content\":\"回复生命500\",\"pt\":0,\"ptNum\":500,\"price\":100}";

    public static string GetString(int id)
    {
        string str = "";
        switch(id)
        {
            case 1:
                str = Herb;
                break;
            case 2:
                str = Ginseng1;
                break;
            case 3:
                str = Ginseng2;
                break;
        }
        return str;
    }
}

public class Box
{
    public enum Type
    {
        Item,
        Equipment,
        Money
    }

    public Type type;

    public int etype;
    //指定类型的ID，用于查找物品、装备
    public int ID;
    public int num;

    public string GetString()
    {
        string str = "你得到了{0}+{1}！";
        string name = "";
        switch(type)
        {
            case Type.Item:
                Item item = JsonUtility.FromJson<Item>(Items.GetString(ID));
                name = item.name;
                str = string.Format(str,name, num);
                break;
            case Type.Equipment:
                name = JsonUtility.FromJson<Equipment>(Equipments.GetString(ID, (Equipment.Type)etype)).name;
                str = string.Format(str,name, num);
                break;
            case Type.Money:
                str = string.Format(str, "金钱", num);
                break;
        }
        return str;
    }

    public void Open()
    {
        GameDataCache dtc = JsonUtility.FromJson<GameDataCache>(PlayerPrefs.GetString("gamedatacache"));;
        switch(type)
        {
            case Type.Item:
                Item item = JsonUtility.FromJson<Item>(Items.GetString(ID));
                int lnum;
                bool istrue = dtc.dItems.TryGetValue(item.ID, out lnum);
                if(istrue)
                {
                    lnum += num;
                    dtc.dItems[ID] = lnum;    
                }
                else
                {
                    lnum = num;
                    dtc.dItems.Add(ID, lnum);
                }
                break;
            case Type.Equipment:
                //str = Equipment.GetString(ID);
                break;
            case Type.Money:
                dtc.money += num;
                break;
        }
        PlayerPrefs.SetString("gamedatacache", JsonUtility.ToJson(dtc));
    }
}
public static class Boxs
{
    public static string Box_1 = "{\"ID\":1,\"type\":0,\"etype\":0,\"num\":1}";
    public static string Box_2 = "{\"ID\":0,\"type\":2,\"etype\":0,\"num\":100}";
    public static string Box_3 = "{\"ID\":1,\"type\":2,\"etype\":0,\"num\":100}";

    public static string GetString(string name)
    {
        string str = "";
        switch(name)
        {
            case "box_1":
                str = Box_1;
                break;
            case "box_2":
                str = Box_2;
                break;
            case "box_3":
                str = Box_3;
                break;
        }
        return str;
    }
}

// public class Equipment
// {
//     public enum Type
//     {
//         Weapon,
//         Clothes,
//         Necklace,
//         Shoes
//     }

//     public enum PropertyType
//     {
//         Attack,
//         Defense,
//         SpiritualPower,
//         MagiceDefense,
//         Speed,
//         Health,
//         Magic,
//         None,
//         Avoidance
//     }

//     public enum User
//     {
//         Nezha,
//         Xiaolongnv,
//         Yangjian,
//         Jiangziya,
//         Male,
//         Famale
//     }

//     public int ID;
//     public string name;
//     public Type type;
//     public User user;
//     public PropertyType basicPtType, extrPtType1, extrPtType2;
//     public int basicPtNum, extrPtNum1, extrPtNum2;
//     public bool isOnUsing;
//     public string content;
    
// }

public static class Equipments
{
    public static string GetString(int id, Equipment.Type type)
    {
        string str = "";
        switch(type)
        {
            case Equipment.Type.Weapon:
                str = Weapon.GetString(id);
                break;
            case Equipment.Type.Clothes:
                str= Clothes.GetString(id);
                break;       
            case Equipment.Type.Shoes:
                str = Shoes.GetString(id);
                break;
        }
        return str;
    }
}

//equipments
public static class Weapon
{
    public static string weapon_01 = "{\"ID\":1,\"name\":\"小刀\",\"type\":0,\"user\":0,\"basicPtType\":0,\"extrPtType1\":7,\"extrPtType2\":7,\"basicPtNum\":15,\"extrPtNum1\":0,\"extrPtNum2\":0,\"isOnUsing\":false,\"content\":\"小小刀具，甚是锋利.\"}";
    public static string weapon_02 = "{\"ID\":2,\"name\":\"手刀\",\"type\":0,\"user\":0,\"basicPtType\":0,\"extrPtType1\":7,\"extrPtType2\":7,\"basicPtNum\":25,\"extrPtNum1\":0,\"extrPtNum2\":0,\"isOnUsing\":false,\"content\":\"袖中之刀，肃穆。\"}";
    
    public static string GetString(int id)
    {
        string str = "";
        switch(id)
        {
            case 1:
                str = weapon_01;
                break;
            case 2:
                str= weapon_02;
                break;       
        }
        return str;
    }
}

public static class Clothes
{
    public static string clothes_01 = "{\"ID\":1,\"name\":\"肚兜\",\"type\":1,\"user\":0,\"basicPtType\":1,\"extrPtType1\":7,\"extrPtType2\":7,\"basicPtNum\":15,\"extrPtNum1\":0,\"extrPtNum2\":0,\"isOnUsing\":false,\"content\":\"\"}";
    public static string GetString(int id)
    {
        string str = "";
        switch(id)
        {
            case 1:
                str = clothes_01;
                break;    
        }
        return str;
    }
}

// public static class Necklace
// {
//     public static string clothes_01 = "{\"ID\":1,\"name\":\"肚兜\",\"type\":1,\"user\":0,\"basicPtType\":1,\"extrPtType1\":7,\"extrPtType2\":7,\"basicPtNum\":15,\"extrPtNum1\":0,\"extrPtNum2\":0,\"isOnUsing\":false,\"content\":\"\"}";
// }

public static class Shoes
{
    public static string shoes_01 = "{\"ID\":1,\"name\":\"麻鞋\",\"type\":3,\"user\":4,\"basicPtType\":8,\"extrPtType1\":7,\"extrPtType2\":7,\"basicPtNum\":3,\"extrPtNum1\":0,\"extrPtNum2\":0,\"isOnUsing\":false,\"content\":\"\"}";
     public static string GetString(int id)
    {
        string str = "";
        switch(id)
        {
            case 1:
                str = shoes_01;
                break;    
        }
        return str;
    }
}