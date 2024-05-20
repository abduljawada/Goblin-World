using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Area Ability", menuName = "Magic/Area Ability")]
public class AreaAbility : Ability
{
    public float radius;
    public int hp;
    public bool stun;
    public bool includePlayer;
}
