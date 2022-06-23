using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorFactory : MonoBehaviour
{
    [SerializeField]
    GameObject GoldPrefab;
    [SerializeField]
    GameObject LeatherPrefab;
    [SerializeField]
    GameObject DragonPrefab;

    public Armor GetArmor(string armor)
    {

        switch (armor)
        {

            case "Gold":
                return new Gold(GoldPrefab);
            case "Leather":
                return new Leather(LeatherPrefab);
            case "Dragon":
                return new Dragon(DragonPrefab);
            default:
                return null;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
