using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFactory : MonoBehaviour
{
    [SerializeField]
    GameObject SwordPrefab;
    [SerializeField]
    GameObject BowPrefab;
    [SerializeField]
    GameObject GunPrefab;
    string AtkTxt;

    public Weapon GetWeapon(string wep) {
        
        switch (wep)
        {

            case "Sword":
                {
                    AtkTxt = "Slash";
                    return new Sword(SwordPrefab);
                }
            case "Bow":
                {
                    AtkTxt = "Whoosh";
                    return new Bow(BowPrefab);
                }
            case "Gun":
                {
                    AtkTxt = "Chiu";
                    return new Gun(GunPrefab);
                }
            default:
                return  null ;
        }
    }
    public string GetText()
    {
        return AtkTxt;
    }
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
