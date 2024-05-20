using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    public int healthLimit;
    [SerializeField] GameObject stunnedCharacter;
    public int healthAmount;
    GameManager gameManager => GameManager.instance;
    InventoryManager inventoryManager => InventoryManager.instance;
    private void Awake()
    {
        healthAmount = healthLimit;
        //OnLevelChanged += MaxHealth();
        
    }

    public void ModifyHealth(int modificationAmount)
    {
        healthAmount += modificationAmount;
        if (healthAmount > healthLimit)
        {
            healthAmount = healthLimit;
        }
        if (healthAmount <= 0)
        {
            Die();
        }
    }

    public void Stun()
    {
        GameObject stunnedObject = Instantiate(stunnedCharacter, transform.position, Quaternion.identity);

        SpriteRenderer stunnedChracterSpriteRenderer = stunnedObject.GetComponent<SpriteRenderer>();
        stunnedChracterSpriteRenderer.sprite = GetComponentInChildren<SpriteRenderer>().sprite;

        stunnedObject.transform.localScale = transform.localScale;

        stunnedObject.GetComponent<DestroyTimer>().originalObj = gameObject;


        gameObject.SetActive(false);
    }

    void MaxHealth()
    {
        healthAmount = healthLimit;
    }

    void Die()
    {
        if (gameObject.tag == "Player")
        {
            gameManager.Restart();
        }
        else
        {
            gameManager.Experience(GetComponent<NPC>().xp);
            inventoryManager.Add(GetComponent<NPC>().gold);
            Destroy(this.gameObject);
            
        }
    }
}
