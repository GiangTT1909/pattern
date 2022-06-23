using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soilder 
{
    public GameObject gameObject;
    public float X;
    public float Y;
    public Weapon Weapon;
    public Armor Armor;

    public Soilder(GameObject gameObject, float x, float y, Weapon weapon, Armor armor)
    {
        this.gameObject = gameObject;
        X = x;
        Y = y;
        Weapon = weapon;
        Armor = armor;
    }
}
