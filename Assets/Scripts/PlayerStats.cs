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
    private FeedbackCalculations feedbackCalcs;

    //Temp storage for score updating from patches
    private bool bossPatch;
    private int hypePatch;
    private bool sponsorPatch;
    private int funPatch;
    private int esportsPatch;

    void Start()
    {
        feedbackCalcs = GetComponent<FeedbackCalculations>();
        setBaseScores();
    }

    public void setBaseScores()
    {
        bossScore = 2;
        hypeScore = 2;
        sponsorScore = 2;
        funScore = 2;
        esportsScore = 2;
    }

    public void updateScores()
    {
        feedbackCalcs = GetComponent<FeedbackCalculations>();
        hypePatch = feedbackCalcs.CalculateHype();
        // Award Score
        if (hypePatch >= 3)
        {
            if (hypePatch == 5)
            {
                hypeScore += 2;
            }
            else
            {
                hypeScore++;
            }
        }
        else if (hypePatch < 3)
        {
            if (hypePatch == 0)
            {
                hypeScore -= 2;
            }
            else
            {
                hypeScore--;
            }
        }
        hypeScore = checkScore(hypeScore);

        funPatch = feedbackCalcs.CalculateFun();
        if (funPatch >= 3)
        {
            if (funPatch == 5)
            {
                funScore += 2;
            }
            else
            {
                funScore++;
            }
        }
        else if (funPatch < 3)
        {
            if (funPatch == 0)
            {
                funScore -= 2;
            }
            else
            {
                funScore--;
            }
        }
        funScore = checkScore(funScore);


        bossPatch = feedbackCalcs.CheckArchetype();
        if (bossPatch)
        {
            bossScore++;
        }
        else
        {
            bossScore--;
        }
        bossScore = checkScore(bossScore);

        sponsorPatch = feedbackCalcs.CheckSponsors();
        if (sponsorPatch)
        {
            sponsorScore++;
        }
        else
        {
            sponsorScore--;
        }
        sponsorScore = checkScore(sponsorScore);

        esportsPatch = feedbackCalcs.CheckBalance();
        if (esportsPatch >= 6)
        {
            if (esportsPatch > 9)
            {
                esportsScore += 2;
            }
            else
            {
                esportsScore++;
            }
        }
        else if (esportsPatch < 5)
        {
            if (esportsPatch < 1)
            {
                esportsScore -= 2;
            }
            else
            {
                esportsScore--;
            }
        }
        esportsScore = checkScore(esportsScore);
    }

    public int getBossScore()
    {
        return bossScore;
    }

    public int getHypeScore()
    {
        return hypeScore;
    }

    public int getSponsorScore()
    {
        return sponsorScore;
    }

    public int getFunScore()
    {
        return funScore;
    }

    public int getEsportsScore()
    {
        return esportsScore;
    }

    public int checkScore(int stat)
    {
        if (stat > 5)
        {
            return 5;
        }
        else if (stat < 0)
        {
            return 0;
        }
        else
        {
            return stat;
        }
        
    }
}
