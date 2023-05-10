using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class Mainmenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoretext;
    
    [SerializeField] int MaxEnergy;

    const string EnergyKey = "Energy";
    private const string EngeryReadyKey = "EnergyReady";

    private int highScore;
    

    private void Start()
    {
        int Energy = PlayerPrefs.GetInt(EnergyKey, MaxEnergy);

        highScore = PlayerPrefs.GetInt("Highscore",0);
        highScoretext.text = $"High Score {highScore}";

        if (Energy == 0) 
        {
            string energyReadyString = PlayerPrefs.GetString(EngeryReadyKey, string.Empty);
            if (energyReadyString == string.Empty) { return; }

           DateTime energyReady = DateTime.Parse (energyReadyString);
            if (DateTime.Now > energyReady)
            {
                Energy = MaxEnergy;
                PlayerPrefs.SetInt(EnergyKey, MaxEnergy);
             }
        }

    }
    public void play()
    {
        DateTime oneMinute = DateTime.Now.AddMinutes(1);
        SceneManager.LoadScene(1);
    }
        
}
