using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Armor
{


    public Dragon(GameObject gameObject)
    {

        this.Prefab = gameObject;
    }

    public GameObject GetPrefab()
    {
        return this.Prefab;
    }

}
