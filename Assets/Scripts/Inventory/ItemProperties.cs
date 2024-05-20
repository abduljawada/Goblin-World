using UnityEngine;

public enum ItemType
{
    Consumable,
    NonConsumable,
    Gold,
    Weapon,
    Shield,
    Armor
}

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public abstract class ItemProperties : ScriptableObject
{
    public ItemType type;
    public int amount = 1;
    public Sprite itemSprite;

    public bool IsStackable()
    {
        switch (type)
        {
            case ItemType.Consumable:
            case ItemType.NonConsumable:
            case ItemType.Gold:
                return true;
            case ItemType.Weapon:
            case ItemType.Shield:
            case ItemType.Armor:
                return false;
        }
        return false;
    }
}
