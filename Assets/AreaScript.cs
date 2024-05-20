using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaScript : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] bool stun;
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] float radius;

    private void Start()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, enemyLayer);
        if (colliders.Length != 0)
        {
            foreach (Collider2D collider in colliders)
            {
                Health collisionHealth = collider.GetComponent<Health>();
                    collisionHealth.ModifyHealth(damage);
                    if (stun)
                    {
                        collisionHealth.Stun();
                    }
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
