using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    InputSystem inputAction;
    Interactable target;
    [SerializeField] float interactingRadius;
    [SerializeField] PlayerMovement movement;
    [SerializeField] Animator dialogueAnimator;
    float timeBtwDialouges;
    [SerializeField] float startTimeBtwDialouges;
    Tooltip tooltip => Tooltip.instance;

    void Awake()
    {
        inputAction = new InputSystem();
        inputAction.Enable();
        inputAction.ActionMap.Interact.performed += ctx => Interact();
        
    }

    void Interact()
    {
        if (target != null)
        {
            if (dialogueAnimator.GetCurrentAnimatorStateInfo(0).IsName("DialogueClose"))
            {
                if (timeBtwDialouges <= 0)
                {
                    target.Interact();
                    timeBtwDialouges = startTimeBtwDialouges;
                }
                
            }         
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeBtwDialouges -= Time.deltaTime;

        Vector2 boxPosition = (Vector2)transform.position + movement.lookDirection;
        Collider2D interactableCollider =  Physics2D.OverlapBox( boxPosition, new Vector2(interactingRadius, interactingRadius), 0);
        if (interactableCollider)
        {
            target = interactableCollider.GetComponent<Interactable>();
            if (target)
            {
                target = interactableCollider.GetComponent<Interactable>();

                string tooltipString = target.name + System.Environment.NewLine + "Press [E] to " + target.interactionType;

                Color tooltipColour = Color.white;

                if (target.interactionType == InteractionType.Steal)
                {
                    tooltipColour = Color.red;
                }

                tooltip.ShowTooltip(tooltipString, target.transform.position, tooltipColour);
            }
            else
            {
                tooltip.HideTooltip();
                target = null;
            }
        }
        else
        {
            tooltip.HideTooltip();
            target = null;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube((Vector2)transform.position + movement.lookDirection, new Vector3(interactingRadius, interactingRadius, interactingRadius));
    }
    
}
