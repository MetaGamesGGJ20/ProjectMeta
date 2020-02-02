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
    }

    void updateFeedback()
    {

        randomString = Random.Range(0, 4);
        bossFeedback = bossFeedbackList[randomString];

        randomString = Random.Range(0, 4);
        crowdFeedback = crowdFeedbackList[randomString];

        randomString = Random.Range(0, 4);
        casualFeedback = casualFeedbackList[randomString];

        randomString = Random.Range(0, 4);
        esportsFeedback = esportsFeedbackList[randomString];

        //Calculate Sponsor requests
        feedbackCalcs.sponsorChar = Random.Range(0, 4);
        feedbackCalcs.sponsorProp = Random.Range(0, 5);
        feedbackCalcs.sponsorValue = Random.Range(1, 5);
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
    '
    public string getEsportsFeedback()
    {
        return esportsFeedback;
    }

    //Update UI
}
