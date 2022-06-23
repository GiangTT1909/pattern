using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
   
    public Sword( GameObject gameObject)
    {
        
        this.Prefab = gameObject;
    }

    public GameObject GetPrefab()
    {
        return Prefab;
    }
}
