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
    private bool esportsPatch;

    void Start()
    {
        feedbackCalcs = GetComponent<FeedbackCalculations>();
        bossScore = 2;
        hypeScore = 2;
        sponsorScore = 2;
        funScore = 2;
        esportsScore = 2;
    }

    public void updateScores()
    {
        hypePatch = feedbackCalcs.CalculateHype();
        // Award Hype Score
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

        funPatch = feedbackCalcs.CalculateFun();
        if (funPatch >= 3)
        {
            if (funPatch == 5)
            {
                funPatch += 2;
            }
            else
            {
                funPatch++;
            }
        }
        else if (funPatch < 3)
        {
            if (funPatch == 0)
            {
                funPatch -= 2;
            }
            else
            {
                funPatch--;
            }
        }

        bossPatch = feedbackCalcs.CheckArchetype();
        if (bossPatch)
        {
            bossScore++;
        }
        else
        {
            bossScore--;
        }

        sponsorPatch = feedbackCalcs.CheckSponsors();
        if (sponsorPatch)
        {
            sponsorScore++;
        }
        else
        {
            sponsorScore--;
        }

        esportsPatch = feedbackCalcs.CheckBalance();
        if (esportsPatch)
        {
            esportsScore++;
        }
        else
        {
            esportsScore--;
        }
    }
}
