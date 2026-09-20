using UnityEngine;


[CreateAssetMenu(fileName = "Question", menuName = "Akinator/Question")]
public class QuestionData : ScriptableObject
{
    public string questionText;
    public string questionType;
}
