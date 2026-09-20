using UnityEngine;

[CreateAssetMenu(fileName = "Brawler", menuName = "Akinator/Brawler")]

public class BrawlerData : ScriptableObject
{
    public string Name;
    public Sprite icon;

    public genderEnum gender;
    // public
}

public enum genderEnum
{
    male, female
}
public enum rarityEnum
{
    male, female
}