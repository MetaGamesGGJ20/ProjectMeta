using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverFeedback : MonoBehaviour
{
    private string bossFeedback;
    private string crowdFeedback;
    private string sponsorFeedback;
    private string casualFeedback;
    private string esportsFeedback;
    private int randomString;

    private int prevBoss;
    private int prevCrowd;
    private int prevCasual;
    private int prevEsports;

    private string randChar;
    private int randAttribute;
    private int randScore;
    private FeedbackCalculations feedbackCalcs;

    public string[] bossFeedbackList;
    public string[] crowdFeedbackList;
    public string[] casualFeedbackList;
    public string[] esportsFeedbackList;

    private void Start()
    {
        feedbackCalcs = GetComponent<FeedbackCalculations>();

        prevBoss = 5;
        prevCrowd = 5;
        prevCasual = 5;
        prevEsports = 5;
        updateFeedback();
    }

    public void updateFeedback()
    {
        feedbackCalcs = GetComponent<FeedbackCalculations>();
        while(randomString != prevBoss)
        {
            randomString = Random.Range(0, 4);
        }
        prevBoss = randomString;
        bossFeedback = bossFeedbackList[randomString];

        while (randomString != prevCrowd)
        {
            randomString = Random.Range(0, 4);
        }
        prevCrowd = randomString;
        crowdFeedback = crowdFeedbackList[randomString];

        while (randomString != prevCasual)
        {
            randomString = Random.Range(0, 4);
        }
        prevCasual = randomString;
        casualFeedback = casualFeedbackList[randomString];

        while (randomString != prevEsports)
        {
            randomString = Random.Range(0, 4);
        }
        prevEsports = randomString;
        esportsFeedback = esportsFeedbackList[randomString];

        //Calculate Sponsor requests
        feedbackCalcs.sponsorChar = Random.Range(0, 4);
        feedbackCalcs.sponsorProp = Random.Range(0, 5);
        feedbackCalcs.sponsorValue = Random.Range(1, 5);
        sponsorFeedback = "Next quarter, make " + feedbackCalcs.characters[feedbackCalcs.sponsorChar].characterName + "'s " + feedbackCalcs.characters[feedbackCalcs.sponsorChar].attributes[feedbackCalcs.sponsorProp] + " the following value: " + feedbackCalcs.sponsorValue.ToString();
    }

    public string getBossFeedback()
    {
        return bossFeedback;
    }

    public string getCrowdFeedback()
    {
        return crowdFeedback;
    }

    public string getSponsorFeedback()
    {
        return sponsorFeedback;
    }

    public string getCasualFeedback()
    {
        return casualFeedback;
    }

    public string getEsportsFeedback()
    {
        return esportsFeedback;
    }

    //Update UI
}
