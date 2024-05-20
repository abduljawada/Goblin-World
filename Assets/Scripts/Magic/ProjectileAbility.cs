using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile Ability", menuName = "Magic/Projectile Ability")]
public class ProjectileAbility : Ability
{
    public Rigidbody2D projectile;
    public float speed;
}
