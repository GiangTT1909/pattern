using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public Gun(GameObject gameObject)
    {

        this.Prefab = gameObject;
    }

    public GameObject GetPrefab()
    {
        return this.Prefab;
    }
}
