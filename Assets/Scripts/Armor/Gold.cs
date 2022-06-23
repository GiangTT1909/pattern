using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Armor
{


    public Gold(GameObject gameObject)
    {

        this.Prefab = gameObject;
    }

    public GameObject GetPrefab()
    {
        return this.Prefab;
    }

}
