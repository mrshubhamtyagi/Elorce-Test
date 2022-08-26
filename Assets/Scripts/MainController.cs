using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [Header("UI")]
    public TMPro.TextMeshProUGUI scoreText;

    [Space(20)]
    public int scoreValueForBlue = 20;
    public int scoreValueForRed = 30;
    public int spawnCount = 20;



    public static MainController Instance;
    private void Awake()
    {
        Instance = this;
    }



    void Start()
    {
        SpawnManager.Instance.SpawnObjects(spawnCount);
        scoreText.text = "Score: ";
    }


    public void UpdateScore(int _score)
    {
        scoreText.text = "Score: " + _score;
    }





}
