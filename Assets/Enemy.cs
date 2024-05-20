using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float sightRadius;
    Health target;
    [SerializeField] LayerMask playerNpcLayer;
    [SerializeField] float maxDistance;
    [SerializeField] float projectileDistance;
    [SerializeField] ProjectileAbility blackMagicProjectile;
    float timeBtwShots;
    [SerializeField] float startTimeBtwShots;
    [SerializeField] Animator animator;
    Rigidbody2D rb => GetComponent<Rigidbody2D>();

    private void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            if (animator != null)
            {
animator.SetBool("Walking", false);
            }
            
            Collider2D targetCollider = Physics2D.OverlapCircle(transform.position, sightRadius, playerNpcLayer);
            if (targetCollider != null)
            {
                target = targetCollider.GetComponent<Health>();
            }
        }
        else
        {
            Vector2 nextPosition = Vector2.MoveTowards(transform.position, target.transform.position, maxDistance * Time.deltaTime);

            if (timeBtwShots <= 0)
            {
                Debug.Log("shoot");

                Vector2 bulletPosition = Vector2.MoveTowards(transform.position, target.transform.position, projectileDistance);

                Rigidbody2D projectile = Instantiate(blackMagicProjectile.projectile, bulletPosition, Quaternion.identity);
                projectile.transform.up = target.transform.position - projectile.transform.position;
                projectile.AddForce(projectile.transform.up * blackMagicProjectile.speed, ForceMode2D.Impulse);

                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }

            if (animator != null)
            {
animator.SetBool("Walking", true);
            animator.SetFloat("X", nextPosition.x - transform.position.x);
            }
            

            transform.position = nextPosition;

            
            
        }
    }
}
