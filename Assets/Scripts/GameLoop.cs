using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLoop : MonoBehaviour
{

    private int quarterNum;
    private FeedbackCalculations feedbackCalcs;
    private PlayerStats playerStats;
    private DeliverFeedback deliverFeedback;
    private DisplayResults displayResults;
    private DisplayWinOrLose displayWinOrLose;
    public TextMeshProUGUI quarterText;
    public AudioClip music;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        feedbackCalcs = GetComponent<FeedbackCalculations>();
        playerStats = GetComponent<PlayerStats>();
        deliverFeedback = GetComponent<DeliverFeedback>();
        displayResults = GetComponent<DisplayResults>();
        displayWinOrLose = GetComponent<DisplayWinOrLose>();
        deliverFeedback.updateFeedback();
        quarterNum = 0;
        roundStart();
    }

    public int getQuarterNum()
    {
        return quarterNum;
    }

    public void roundStart()
    {
        quarterNum++;
        quarterText.text = "Quarter " + quarterNum.ToString();
        for(int i = 0; i < 5; i++)
        {
            feedbackCalcs.characters[i].setRoundValues();
        }
        source.Play();
    }

    public void roundEnd()
    {
        source.Stop();
        playerStats.updateScores();
        deliverFeedback.updateFeedback();
        if (quarterNum < 4)
        {
            StartCoroutine(displayResults.ActivateResultsCanvas());
        }
        else
        {
            StartCoroutine(displayWinOrLose.ActivateResultsCanvas());
        }
    }
}
