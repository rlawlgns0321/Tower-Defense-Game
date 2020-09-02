/*
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Inventory {

    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public InventoryData my_inven;
    public itemData Initial_StandardTurret;
    public itemData Initial_MissileLauncher;
    public itemData Initial_LaserBeamer;
	
	public void Initialize_Inventory()
    {
        my_inven = new InventoryData();
        my_inven.items = new List<itemData>();
        T1 = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/StandardTurret.prefab", typeof(GameObject));
        T2 = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Missile Launcher.prefab", typeof(GameObject));
        T3 = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Laser Beamer.prefab", typeof(GameObject));
        Initial_StandardTurret = new itemData(T1.name, "Standard Turret", T1, "Resources/Icons/StandardTurretIcon.png", new Vector3(0f, 0f, 0f));
        Initial_MissileLauncher = new itemData(T2.name, "Missile Launcher", T2, "Resources/Icons/MissileLauncherIcon.png", new Vector3(0f, 0f, 0f));
        Initial_LaserBeamer = new itemData(T3.name, "Laser Beamer", T3, "Resources/Icons/LaserBeamerIcon.png", new Vector3(0f, 0f, 0f));

        my_inven.items.Add(Initial_StandardTurret);
        my_inven.items.Add(Initial_MissileLauncher);
        my_inven.items.Add(Initial_LaserBeamer);
    }

    public void Save_Inventory()
    {
        DataManager.Serialize<InventoryData>(my_inven, DataManager.savePath + "/Inventory.dat");
    }

    public void Load_Inventory()
    {
        my_inven = DataManager.Deserialize<InventoryData>(DataManager.savePath + "/Inventory.dat");
    }

    public void Add_Items_in_Inventory(itemData I)
    {
        my_inven.items.Add(I);
    }

    public void Delete_Items_in_Inventory(itemData I)
    {
        return;
    }
}*/

//enable this when you try making inventory system.
