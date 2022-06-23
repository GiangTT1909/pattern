using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{

   
    public Bow(GameObject gameObject)
    {

        this.Prefab = gameObject;
    }

    public GameObject GetPrefab()
    {
        return this.Prefab;
    }

}
