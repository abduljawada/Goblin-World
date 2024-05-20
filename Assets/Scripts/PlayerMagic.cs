using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{
    [SerializeField] PlayerMana mana;
    [SerializeField] PlayerMovement movement;
    [SerializeField] Health health;
    [SerializeField] ProjectileAbility[] prefabAbilities = new ProjectileAbility[7];
    [SerializeField] SelfHealingAbility selfHealingsAbility;
    InputSystem inputAction;

    void Awake()
    {
        inputAction = new InputSystem();
        inputAction.Enable();

        //Prefab Abilities
        inputAction.ActionMap.BlackMagicProjectile.performed += ctx => PrefabAbility(prefabAbilities[5]);
        inputAction.ActionMap.LightiningProjectile.performed += ctx => PrefabAbility(prefabAbilities[3]);
        inputAction.ActionMap.ShieldDome.performed += ctx => PrefabAbility(prefabAbilities[1]);
        inputAction.ActionMap.ShieldWall.performed += ctx => PrefabAbility(prefabAbilities[2]);
        inputAction.ActionMap.WhiteMagicArea.performed += ctx => PrefabAbility(prefabAbilities[0]);
        inputAction.ActionMap.LightiningArea.performed += ctx => PrefabAbility(prefabAbilities[4]);
        inputAction.ActionMap.BlackMagicArea.performed += ctx => PrefabAbility(prefabAbilities[6]);

        //Area Abilities


        //Self heal
        inputAction.ActionMap.WhiteMagicSelf.performed += ctx => SelfHeal(selfHealingsAbility);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrefabAbility(ProjectileAbility ability)
    {
        if (mana.SpendMana(ability.manaCost))
        {
            if (ability == prefabAbilities[0] || ability == prefabAbilities[4] || ability == prefabAbilities[6] || ability == prefabAbilities[1])
            {
                Instantiate(ability.projectile, transform.position, Quaternion.identity);
            }
            else
            {
                Rigidbody2D projectileObject = Instantiate(ability.projectile, transform.position + (Vector3) movement.lookDirection * 1.5f, Quaternion.identity);
                projectileObject.transform.up = projectileObject.transform.position - transform.position;
                projectileObject.AddForce(projectileObject.transform.up * ability.speed, ForceMode2D.Impulse);

            }
            
        }
    }

    void SelfHeal(SelfHealingAbility ability)
    {
        if (mana.SpendMana(ability.manaCost))
        {
            health.ModifyHealth(ability.healAmount);
        }
    }

    void AreaAbility(AreaAbility ability)
    {
        Collider2D[] collidersInArea = Physics2D.OverlapCircleAll(transform.position, ability.radius);
        foreach (Collider2D collider in collidersInArea)
        {
            if (ability.includePlayer)
            {
                Health colliderHealth = collider.GetComponent<Health>();
                if (colliderHealth != null)
                {
                    colliderHealth.ModifyHealth(ability.hp);
                    if (ability.stun)
                    {
                        colliderHealth.Stun();
                    }
                }
            }
            else
            {
                if (collider.tag != "Player")
                {
                    Health colliderHealth = collider.GetComponent<Health>();
                    if (colliderHealth != null)
                    {
                        colliderHealth.ModifyHealth(ability.hp);
                        if (ability.stun)
                        {
                            colliderHealth.Stun();
                        }
                    }
                }
            }
        }
    }
}
