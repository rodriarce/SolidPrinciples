using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour, IBullet
{
    public int Damage { get
        {
            return damage;
        }            
        set
        { damage = value; 
        }
    }

    public GameObject PrefabBullet {
        get
        {
            return prefabBullet;
        }
        set
        {
            prefabBullet = value;
        }

    }
    public GameObject prefabBullet;
    

    public int damage;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBullet()
    {
        GameObject newProjectile = Instantiate(prefabBullet);
        newProjectile.transform.position = prefabBullet.transform.position;
        newProjectile.GetComponent<DamageBullet>().Damage = Damage;
        newProjectile.SetActive(true);
    }
}
