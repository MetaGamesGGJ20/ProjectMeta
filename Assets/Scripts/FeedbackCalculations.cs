using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackCalculations : MonoBehaviour
{
    public Character[] characters;

    public int sponsorChar;
    public int sponsorProp;
    public int sponsorValue;

    public int CalculateHype()
    {
        int patchHypeScore = 0;

        for(int i = 0; i < 5; i++)
        {
            if ((characters[i].getAttackSpeed() + characters[i].getMobility() + characters[i].getLuck()) >= 8)
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
            if ((characters[i].getAttackPower() + characters[i].getRange() + characters[i].getHealth()) >= 8)
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

        if(patchBossScore >= 15)
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
        if(sponsorProp == 0)
        {
            if(characters[sponsorChar].getAttackPower() == sponsorValue)
            {
                return true;
            }
        }
        else if (sponsorProp == 1)
        {
            if (characters[sponsorChar].getAttackSpeed() == sponsorValue)
            {
                return true;
            }
        }
        else if (sponsorProp == 2)
        {
            if (characters[sponsorChar].getHealth() == sponsorValue)
            {
                return true;
            }
        }
        else if (sponsorProp == 3)
        {
            if (characters[sponsorChar].getMobility() == sponsorValue)
            {
                return true;
            }
        }
        else if (sponsorProp == 4)
        {
            if (characters[sponsorChar].getRange() == sponsorValue)
            {
                return true;
            }
        }
        else if (sponsorProp == 5)
        {
            if (characters[sponsorChar].getLuck() == sponsorValue)
            {
                return true;
            }
        }

        return false;
    }

    public int CheckBalance()
    {
        int patchBalanceScore = 0;

        for (int i = 0; i < 5; i++)
        {
            int char1Score = 0;

            for (int j = i+1; j < 5; j++)
            {
                int char2Score = 0;

                // Do not compare matchup if character is the same.
                if (i == j)
                {
                    continue;
                }
                // Get stats for each character
                // Compare Stats; if one is greater, add point.

                /*Attack Power*/
                if(characters[i].getAttackPower() > characters[j].getAttackPower())
                {
                    char1Score++;
                    char2Score--;
                }
                else if(characters[i].getAttackPower() < characters[j].getAttackPower())
                {
                    char1Score--;
                    char2Score++;
                }

                /*Attack Speed*/
                if (characters[i].getAttackSpeed() > characters[j].getAttackSpeed())
                {
                    char1Score++;
                    char2Score--;
                }
                else if (characters[i].getAttackSpeed() < characters[j].getAttackSpeed())
                {
                    char1Score--;
                    char2Score++;
                }

                /*Health*/
                if (characters[i].getHealth() > characters[j].getHealth())
                {
                    char1Score++;
                    char2Score--;
                }
                else if (characters[i].getHealth() < characters[j].getHealth())
                {
                    char1Score--;
                    char2Score++;
                }

                /*Mobility*/
                if (characters[i].getMobility() > characters[j].getMobility())
                {
                    char1Score++;
                    char2Score--;
                }
                else if (characters[i].getMobility() < characters[j].getMobility())
                {
                    char1Score--;
                    char2Score++;
                }

                /*Range*/
                if (characters[i].getRange() > characters[j].getRange())
                {
                    char1Score++;
                    char2Score--;
                }
                else if (characters[i].getRange() < characters[j].getRange())
                {
                    char1Score--;
                    char2Score++;
                }

                /*Luck*/
                if (characters[i].getLuck() > characters[j].getLuck())
                {
                    char1Score++;
                    char2Score--;
                }
                else if (characters[i].getLuck() < characters[j].getLuck())
                {
                    char1Score--;
                    char2Score++;
                }

                if((char1Score - char2Score) < 1 || (char1Score - char2Score) > -1)
                {
                    patchBalanceScore++;
                }
            }
        }

        return patchBalanceScore;
    }
}
