using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerProperty
{
    public string name;
     public int grade;
    
    public int maxHealthValue;
    
    public int healthValue;
    
    public int maxMagicalValue;
    
    public int magicalValue;
    

    public int attackPower;
    
    public int defensePower;
    
    public int spiritualPower;
    
    public int magicDefensePower;
    
    public int speed;
    
    //回避力
    public int avoidance;
    
    //经验值
    public int exp;
    

    //装备编号
    public int weapon01;
    
    public int weapon02;
    
    public int clothes;
    
    public int shoes;
    
    public int necklace;
    

    //人物位置的坐标值
    public Vector2 position;
    public string Name { get => name; set => name = value; }
    public int Grade { get => grade; set => grade = value; }
    public int MaxHealthValue { get => maxHealthValue; set => maxHealthValue = value; }
    public int HealthValue { get => healthValue; set => healthValue = value; }
    public int MaxMagicalValue { get => maxMagicalValue; set => maxMagicalValue = value; }
    public int MagicalValue { get => magicalValue; set => magicalValue = value; }
    public int AttackPower { get => attackPower; set => attackPower = value; }
    public int DefensePower { get => defensePower; set => defensePower = value; }
    public int SpiritualPower { get => spiritualPower; set => spiritualPower = value; }
    public int MagicDefensePower { get => magicDefensePower; set => magicDefensePower = value; }
    public int Speed { get => speed; set => speed = value; }
    public int Avoidance { get => avoidance; set => avoidance = value; }
    public int Exp { get => exp; set => exp = value; }
    public int Weapon01 { get => weapon01; set => weapon01 = value; }
    public int Weapon02 { get => weapon02; set => weapon02 = value; }
    public int Clothes { get => clothes; set => clothes = value; }
    public int Shoes { get => shoes; set => shoes = value; }
    public int Necklace { get => necklace; set => necklace = value; }
    public Vector2 Position { get => position; set => position = value; }

   
    

    public PlayerProperty()
    {

    }

}

public static class PlayerProperties
{
    public static string sNezha = "{\"name\":\"nezha\",\"grade\":0,\"maxHealthValue\":150,\"healthValue\":150,\"maxMagicalValue\":150,\"magicalValue\":150,\"attackPower\":15,\"defensePower\":15,\"spiritualPower\":15,\"magicDefense\":5, \"speed\":5,\"avoidance\":1,\"exp\":0,\"weapon01\":0,\"weapon02\":0,\"clothes\":0,\"shoes\":0,\"necklace\":0,\"position\":{\"x\":0,\"y\":0}}";
}