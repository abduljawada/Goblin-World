using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    InputSystem inputAction;
    Vector2 movementInput;
    [HideInInspector] public Vector2 lookDirection;
    public float moveSpeed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Animator animator;

    void Awake()
    {
        inputAction = new InputSystem();
        inputAction.Enable();
        inputAction.ActionMap.Move.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movementInput != Vector2.zero)
        {
            lookDirection = movementInput.normalized;

            animator.SetFloat("X", lookDirection.x);
            animator.SetFloat("Y", lookDirection.y);

            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementInput.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
