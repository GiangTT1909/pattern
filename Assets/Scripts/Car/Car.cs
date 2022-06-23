using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car 
{
    public GameObject Prefab;
    public float speed;

    public abstract void Run();
}
