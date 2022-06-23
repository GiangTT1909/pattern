using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISoilderBuilder 
{
    ISoilderBuilder AddWeapon(string wep);
    ISoilderBuilder AddArmor(string amr);
    ISoilderBuilder AddLocation(float X,float Y);
    ISoilderBuilder AddPrefab(GameObject prefab);
    string GetText();
    Soilder build();

}
