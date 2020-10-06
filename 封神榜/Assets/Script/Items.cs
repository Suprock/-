using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Item
{
    enum Type
    {
        //药品
        Drug,
        Material,
        //法宝
        Sutra,
        Common
    }

    enum PropertyType
    {
        Health,
        Magic,
        Detoxify
    }
    int ID {get;set;}
    string name {get;set;}
    Type type {get;set;}
    string content {get;set;}
    PropertyType pt {get;set;}
    int ptNum;
    int price {get;set;}
    // Start is called before the first frame update
    public Item()
    {

    }
}

public static class Items
{
    public static string Herb = "{ID:1,name:\"药草\",type:0,content:\"回复生命50\",pt:0,ptNum:50,price:30}";
    public static string Ginseng1 = "{id:2,name:\"参须\",type:0,content:\"回复生命200\",pt:0,ptNum:200,price:60}";
    public static string Ginseng2 = "{id:3,name:\"人参\",type:0,content:\"回复生命500\",pt:0,ptNum:500,price:100}";
}
