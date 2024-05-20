using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Choice", menuName = "Dialogue/Dialogue Choice")]
public class DialogueChoice : ScriptableObject
{
    public string choiceText;
    public DialogueNode nextNode;
    public bool costs;
    public int amount;
    public int health;
    public int mana;
}
