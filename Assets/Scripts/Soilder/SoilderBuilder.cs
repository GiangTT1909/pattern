using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilderBuilder : ISoilderBuilder
{
    public GameObject gameObject;
    public float X;
    public float Y;
    public Weapon Weapon;
    public Armor Armor;
    public string AtkTxt;
    public ISoilderBuilder AddLocation(float X, float Y)
    {
        this.X = X;
        this.Y = Y;
        return this;
    }

    public ISoilderBuilder AddPrefab(GameObject prefab)
    {
        this.gameObject = prefab;
        return this;
    }

    public ISoilderBuilder AddWeapon(string wep)
    {
        WeaponFactory factory = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<WeaponFactory>();     
        this.Weapon = factory.GetWeapon(wep);
        AtkTxt = factory.GetText();
        return this;
    }
    public ISoilderBuilder AddArmor(string amr)
    {
        ArmorFactory factory = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ArmorFactory>();
        
        this.Armor = null;
        return this;
    }
    public string GetText()
    {
        return AtkTxt;
    }
    public Soilder build()
    {
        return new Soilder(gameObject, X, Y, Weapon, Armor);
    }
}
