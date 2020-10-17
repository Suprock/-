using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasicEquipment
{
    //id	name	basicpt	pttype	content	user
    public int id;
    public string name;
    public PropertyType basicType;
    public int basicpt;
    public string content;
    public int user;
}
public class Equipment : BasicEquipment
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public PropertyType extrType1, extrTpye2;
    public int extrpt1, extrpt2;
    private bool isOnUsing;

    public bool IsOnUsing { get => isOnUsing; set => isOnUsing = value; }

    public Equipment(string str)
    {
        BasicEquipment be = JsonUtility.FromJson<BasicEquipment>(str);
        id = 1;
        name = be.name;
        basicType = be.basicType;
        basicpt = be.basicpt;
        content = be.content;
        user = be.user;
    }
    public void Onusing(int iuser)
    {
        isOnUsing = true;
        user = iuser;
    }


}

public static class Equipments
{
    public static string e1 = "{\"ID\":1001,\"name\":\"小刀\",\"user\":0,\"basicType\":0,\"basicpt\":15,\"content\":\"小小刀具，甚是锋利.\"}";
    public static string e2 = "{\"ID\":1002,\"name\":\"手刀\",\"user\":0,\"basicType\":0,\"basicpt\":35,\"content\":\"小小刀具，甚是锋利.\"}";

    public static string GetString(int id)
    {
        string str = "";
        switch(id)
        {
            case 1001:
                str = e1;
                break;
            case 1002:
                str = e2;
                break;
        }
        return str;
    }
}


public enum Type
{
    Weapon,
    Clothes,
    Necklace,
    Shoes
}
public enum PropertyType
{
    Attack = 1,
    Defense,
    SpiritualPower,
    MagiceDefense,
    Speed,
    Health,
    Magic,
    None,
    Avoidance
}

public enum Users
{
    nezha = 1,
    xiaolongnv,
    yangjian,
    jiangziya,
    male,
    famale
}

