using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour // Base Enemy Class
{
    public float speedShip;    

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {         
          GetComponent<IEnemyHealth>().GetDamage(GameManager.instance.baseBullet.damageBullet);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
