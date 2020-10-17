using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameDataCache
{
    // Start is called before the first frame update
    public int money;
    public int sceneID;
    
    public List<PlayerProperty> LP = new List<PlayerProperty>();
    public Dictionary<int, int> dItems = new Dictionary<int, int>();
    public GameDataCache()
    {

    }

    public List<PlayerProperty> LP1 { get => LP; set => LP = value; }
    public Dictionary<int, int> DItems { get => dItems; set => dItems = value; }
}