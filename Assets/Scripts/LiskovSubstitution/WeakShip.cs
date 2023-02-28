using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakShip : EnemyShip // Inherit from Base Class
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void GetDamage(int damage)
    {
        damage += 20;
        base.GetDamage(damage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
