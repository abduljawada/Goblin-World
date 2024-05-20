using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public static GameManager instance;
    [SerializeField] Health playerHealth;
    [SerializeField] PlayerMana playerMana;
    [SerializeField] PlayerMovement playerMovement;
    //public delegate void 
    [SerializeField] int[] xpLimits;
    public int xpLimit;
    public int xpAmount;
    public int level = 1;
    [SerializeField] Vector2 boxCastSize;
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] GameObject winUI;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    private void Update()
    {
        Collider2D[] enemiesAlive = Physics2D.OverlapBoxAll(transform.position, boxCastSize, 0f, enemyLayer);
        if (enemiesAlive.Length == 0)
        {
            winUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Experience(int xp)
    {
        xpAmount += xp;

        if (xpAmount >= xpLimit)
        {
            LevelUp();
        }

    }

    public void LevelUp()
    {
        level++;
        xpAmount = 0;

        if (level == 9)
        {
            xpLimit = int.MaxValue;
        }
        else
        {
            xpLimit = xpLimits[level - 1];
        }
        
        playerMovement.moveSpeed++;
        playerHealth.healthLimit += 50;
        playerMana.manaAmoutLimit += 50;
        playerHealth.healthAmount = playerHealth.healthLimit;
        playerMana.manaAmount = playerMana.manaAmoutLimit;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, boxCastSize);
    }
}
