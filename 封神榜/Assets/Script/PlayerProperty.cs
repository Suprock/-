using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperty : MonoBehaviour
{
    [Header("人物属性")]
    private string name;
    private int grade;
    private int maxHealthValue;
    private int healthValue;
    private int maxMagicalValue;
    private int magicalValue;

    private int attackPower;
    private int defense;
    private int spiritualPower;
    private int magicDefense;
    private int speed;
    private int avoidance;

    [Header("携带装备")]
    //装备编号
    private int weapon01;
    private int weapon02;
    private int clothes;
    private int shoes;
    private int necklace;

    [Header("坐标")]
    //人物位置的坐标值
    private Vector2 position;

    public PlayerProperty(string lname)
    {
        name = lname;
    }
    // Start is called before the first frame update
    void GetPropertyInArchive()
    {
        //在存档中获取所有信息
    }

    public void InitZeroProperty()
    {
        //设置主角0J的属性
        // int zeroMaxHealthValue = 150;
        // int zeroMaxMagicalValue = 150;

        // int zeroAttackPower = 5;
        // int zeroDefense = 5;
        // int zeroSpiritualPower = 5;
        // int zeroMagicDefense = 5;
        // int zeroSpeed = 5;
        switch(name)
        {
            case "nezha":
                grade = 0;
                healthValue = maxHealthValue = 150;
                magicalValue = maxMagicalValue = 150;
                attackPower = 15;
                defense = 10;
                spiritualPower = 5;
                magicDefense = 5;
                speed = 5;
                avoidance = 0;
                weapon01 = 0;
                weapon02 = 0;
                clothes = 0;
                necklace = 0;
                shoes = 0;
                break;
        }
    }




}
