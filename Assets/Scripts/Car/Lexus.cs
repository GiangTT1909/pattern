using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lexus : Car {
    public Lexus(GameObject prefab, float speed) {
        this.Prefab = prefab;
        this.speed = speed;
    }

    public override void Run()
    {
       Prefab.GetComponent<CarBehavior>().Run(this.speed);
    }
}
