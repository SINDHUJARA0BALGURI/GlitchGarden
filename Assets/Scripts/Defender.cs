using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    public GameObject projectile, projectileParent;

    void ProjectileFire()
    {
        GameObject tempProjectile = Instantiate(projectile) as GameObject;
        tempProjectile.transform.position = projectileParent.transform.position;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
    // Start is called before the first frame update
   /* void Update()
    {
        GameObject.FindObjectOfType<Attackers>().Attack(gameObject);
    }*/

    
}
