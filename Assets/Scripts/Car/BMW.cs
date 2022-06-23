using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMW : Car
{
    // Start is called before the first frame update
    public BMW(GameObject prefab, float speed)
    {
        this.Prefab = prefab;
        this.speed = speed;
    }

    public override void Run()
    {
        Prefab.GetComponent<CarBehavior>().Run(this.speed);
    }
}
