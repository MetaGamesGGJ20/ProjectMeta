using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackCalculations : MonoBehaviour
{
    public Character[] characters;
    
    public int CalculateHype()
    {
        int patchHypeScore = 0;

        for(int i = 0; i < 5; i++)
        {
            if ((characters[i].getAttackSpeed() + characters[i].getMobility() + characters[i].getLuck()) >= 10)
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

            if ((characters[i].getAttackPower() + characters[i].getRange() + characters[i].getHealth()) >= 10)
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
            if(characters[i].getAttackSpeed() == characters[i].desiredAttackSpeed)
            {
                patchBossScore++;
            }

            if (characters[i].getAttackPower() == characters[i].desiredAttackPower)
            {
                patchBossScore++;
            }

            if (characters[i].getRange() == characters[i].desiredRange)
            {
                patchBossScore++;
            }

            if (characters[i].getHealth() == characters[i].desiredHealth)
            {
                patchBossScore++;
            }

            if (characters[i].getMobility() == characters[i].desiredMobility)
            {
                patchBossScore++;
            }

            if (characters[i].getLuck() == characters[i].desiredLuck)
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
        for (int i = 0; i < 5; i++)
        {
            for (int j = i+1; j < 5; j++)
            {
                // Do not compare matchup if character is the same.
                if (i == j)
                {
                    continue;
                }
                // Get stats for each character
                // Compare Stats; if one is greater, add point.
                if()
            }
        }
        //NOTE: Create separate compare character function to test matchups that is called in checkbalance.
        return true;
    }
}
