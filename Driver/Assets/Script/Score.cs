using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int multiplier;
   
    string Highscore = "Highscore";
    float score;
    int roundedScore;
    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*multiplier;
        roundedScore=Mathf.RoundToInt(score);
        scoreText.text = roundedScore.ToString();
    }
    private void OnDestroy()
    {
        int currentScore=PlayerPrefs.GetInt(Highscore, 0);
        if (score > currentScore)
        {
            PlayerPrefs.SetInt(Highscore, roundedScore);    
         }
    }
}
