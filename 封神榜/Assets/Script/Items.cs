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
    public int ID {get;set;}
    public string name {get;set;}
    public Type type {get;set;}
    public string content {get;set;}
    public PropertyType pt {get;set;}
    public int ptNum;
    public int price {get;set;}
    // Start is called before the first frame update
    public Item()
    {

    }
}

public static class Items
{
    public static string Herb = "{\"ID\":1,\"name\":\"药草\",\"type\":0,\"content\":\"回复生命50\",\"pt\":0,\"ptnum\":50,\"price\":30}";
    public static string Ginseng1 = "{\"ID\":2,\"name\":\"参须\",\"type\":0,\"content\":\"回复生命200\",\"pt\":0,\"ptnum\":200,\"price\":60}";
    public static string Ginseng2 = "{ID:3,name:\"人参\",type:0,content:\"回复生命500\",pt:0,ptNum:500,price:100}";
}

public static class Boxs
{
    public static string Box_1 = "";
}
