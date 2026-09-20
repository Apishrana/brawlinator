using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<BrawlerData> brawlers;
    [SerializeField]
    private List<QuestionData> questions;
    private List<BrawlerData> candidates;

    private int questionIndex;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
