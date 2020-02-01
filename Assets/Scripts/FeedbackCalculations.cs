﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackCalculations : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject playerStats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateAll()
    {
        CalculateHype();
        CalculateFun();
        CheckArchetype();
    }

    public int CalculateHype()
    {
        int patchHypeScore = 0;

        for(int i = 0; i < 5; i++)
        {
            //load in from character stats
            int charAttSpeed = 0;
            int charMobiity = 0;
            int charLuck = 0;

            if ((charAttSpeed + charMobiity + charLuck) >= 10)
            {
                patchHypeScore++;
            }
        }

        return patchHypeScore;
    }

    public int CalculateFun()
    {
        int patchFunScore = 0;

        for(int i = 0; i < 5; i++)
        {
            //load in from character stats
            int charAttPower = 0;
            int charRange = 0;
            int charHealth = 0;

            if ((charAttPower + charRange + charHealth) >= 10)
            {
                patchFunScore++;
            }
        }

        return patchFunScore;
    }

    public bool CheckArchetype()
    {
        int patchBossScore = 0;

        for (int i = 0; i < 5; i++)
        {
            int attSpeed = 0;
            int desiredAttSpeed = 0;
            int attPower = 0;
            int desiredAttPower = 0;
            int range = 0;
            int desiredRange = 0;
            int health = 0;
            int desiredHealth = 0;
            int mobility = 0;
            int desiredMobility = 0;
            int luck = 0;
            int desiredLuck = 0;

            if(attSpeed == desiredAttSpeed)
            {
                patchBossScore++;
            }

            if(attPower == desiredAttPower)
            {
                patchBossScore++;
            }

            if(range == desiredRange)
            {
                patchBossScore++;
            }

            if(health == desiredHealth)
            {
                patchBossScore++;
            }

            if(mobility == desiredMobility)
            {
                patchBossScore++;
            }

            if(luck == desiredLuck)
            {
                patchBossScore++;
            }
        }

        if(patchBossScore >= 20)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CheckSponsors()
    {
        return true;
    }

    public bool CheckBalance()
    {
        return true;
    }
}
