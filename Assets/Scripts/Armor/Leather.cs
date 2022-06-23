using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leather : Armor
{


    public Leather(GameObject gameObject)
    {

        this.Prefab = gameObject;
    }

    public GameObject GetPrefab()
    {
        return this.Prefab;
    }

}
