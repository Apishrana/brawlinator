using UnityEngine;

[CreateAssetMenu(fileName = "Brawler", menuName = "Akinator/Brawler")]

public class BrawlerData : ScriptableObject
{
    public string Name;
    public Sprite Icon;

    public genderEnum Gender;
    public rarityEnum Rarity;
    public classEnum Class;
    public speedEnum Speed;

    public bool Robot;
    public bool Jump;
    public bool DestroyWalls;
    public bool DestroyBush;
    public bool Stun;
    public bool Slow;
    public bool Family;
    public bool BypassWall;
    public bool Splash;
    public bool Burn;
    public bool Poison;
    public bool Invisibility;
    public bool Buffies;
}

public enum genderEnum
{
    male, female
}
public enum rarityEnum
{
    Starting, Rare, Super_Rare, Epic, Mythic, Legendary, Ultra
}
public enum classEnum
{
    Tank, Assassin, Support, Controller, Damage_Dealer, Marksman, Artillery
}
public enum speedEnum
{
    Normal, Fast, Very_Fast, Very_Slow, Slow
}