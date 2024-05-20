using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] bool pierce;
    [SerializeField] bool stun;
    [SerializeField] bool includePlayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health collisionHealth = collision.GetComponent<Health>();
        if (collisionHealth != null)
        {
            if (includePlayer)
            {
                collisionHealth.ModifyHealth(damage);
                if (stun)
                {
                    collisionHealth.Stun();
                }
                if (!pierce)
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                if (collision.tag != "Player")
                {
                    collisionHealth.ModifyHealth(damage);
                    if (stun)
                    {
                        collisionHealth.Stun();
                    }
                    if (!pierce)
                    {
                        Destroy(this.gameObject);
                    }
                }
            }
            
        }
        else
        {
            Destroy(this.gameObject);
        }

        
    }
}
