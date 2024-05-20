using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NPC : Interactable
{
    public DialogueManager dialogueManager => DialogueManager.instance;

    public DialogueNode startingNode;
    public int xp;
    public int gold;

    public override void Interact()
    {
        base.Interact();
        //Start Dialogue
        dialogueManager.StartDialogue(name, startingNode);
    }
}
