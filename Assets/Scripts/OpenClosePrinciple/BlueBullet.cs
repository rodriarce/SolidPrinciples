using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlueBullet : BaseBullet, IBullet
{
       
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
        newProjectile.SetActive(true);
    }
}
