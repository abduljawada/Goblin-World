using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public Sprite icon;
    public AudioClip sound;
    public int manaCost;
}
