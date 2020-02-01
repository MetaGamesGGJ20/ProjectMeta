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

    private int randChar;
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

        randChar = Random.Range(0, 4);
        randAttribute = Random.Range(0, 5);
        randScore = Random.Range(1, 5);

    }

    //Update UI
}
