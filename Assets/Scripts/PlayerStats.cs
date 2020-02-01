using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int bossScore;
    private int hypeScore;
    private int sponsorScore;
    private int funScore;
    private int esportsScore;

    void Start()
    {
        bossScore = 2;
        hypeScore = 2;
        sponsorScore = 2;
        funScore = 2;
        esportsScore = 2;
    }

    public void updateScores()
    {
        print("Test");
    }
}
