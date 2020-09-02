using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct playerData
{
    public string name;
    public string level;
}

[System.Serializable]
public struct itemData { 
    public string name;
    public string discription;
    public GameObject turret_model;
    public string spritePath;
    public Vector3 position;
    public itemData(string name, string discription, GameObject turret_model, string spritePath, Vector3 position)
    {
        this.name = name;
        this.discription = discription;
        this.turret_model = turret_model;
        this.spritePath = spritePath;
        this.position = position;
    }
}

[System.Serializable]
public struct InventoryData
{
    public List<itemData> items;
}

