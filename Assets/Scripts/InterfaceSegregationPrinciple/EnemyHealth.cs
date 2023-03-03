using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IEnemyHealth
{
    public int health;
    public int Health { get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public void GetDamage(int damage)
    {
        Health -= (int)damage;
        if (Health <= 0)
        {
            Debug.Log("Death Ship");
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            GetDamage((int)other.GetComponent<EnemyBullet>().damage);
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
