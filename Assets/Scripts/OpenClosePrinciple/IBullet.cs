using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBullet
{
    public GameObject PrefabBullet
    {
        get;
        set;
    }
    public int Damage
    { get; 
        set; 
    }
    void CreateBullet();
    
}