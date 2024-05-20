using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum InteractionType
{
    Take,
    Steal,
    Talk
}

public class Interactable : MonoBehaviour
{
    new public string name;
    public InteractionType interactionType;

    public virtual void Interact()
    {
        Debug.Log("You " + interactionType + " " + name);
    }

}

