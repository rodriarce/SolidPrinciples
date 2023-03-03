using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [HideInInspector]
    public float damage;
    [HideInInspector]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetData(float damage, float speed)
    {
        this.damage = damage;
        this.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * -transform.up);
    }

 
}
