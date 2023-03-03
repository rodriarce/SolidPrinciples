using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GetDamage(int damage)
    {
        health -= damage;
    }
    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("EnemyBullet"))
        {
            GetDamage((int)other.GetComponent<EnemyBullet>().damage);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
