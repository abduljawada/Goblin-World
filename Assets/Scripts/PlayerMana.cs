using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    public int manaAmoutLimit;
    public int manaAmount;
    public static PlayerMana instance;

    private void Awake()
    {
        instance = this;
        manaAmount = manaAmoutLimit;
    }
    public bool SpendMana(int amountSpent)
    {
        if (amountSpent > manaAmount)
        {
            return false;
        }
        else
        {
            manaAmount -= amountSpent;
            return true;
        }
    }

    public void RegainMana(int amountRegan)
    {
        manaAmount += amountRegan;
        if (manaAmount > manaAmoutLimit)
        {
            manaAmount = manaAmoutLimit;
        }
    }

    void MaxMana()
    {
        manaAmount = manaAmoutLimit;
    }
}
