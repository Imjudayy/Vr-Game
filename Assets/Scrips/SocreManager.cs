using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SocreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score =0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score = {score}";
        if (score >= 5) 
        {
            scoreText.text = " You Win!";
        }
    }
}
