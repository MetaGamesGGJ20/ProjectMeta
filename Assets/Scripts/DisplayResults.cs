using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayResults : MonoBehaviour
{
    public GameObject resultsCanvas;
    public AudioClip fanfare;
    public AudioSource source;

    public TextMeshProUGUI bossHappiness;
    public TextMeshProUGUI BossFeedback;

    public TextMeshProUGUI sponsorshipSatisfaction;
    public TextMeshProUGUI sponsorFeedback;

    public TextMeshProUGUI publicInterest;
    public TextMeshProUGUI crowdFeedback;

    public TextMeshProUGUI esportViewCount;
    public TextMeshProUGUI esportFeedback;

    public TextMeshProUGUI casualInterest;
    public TextMeshProUGUI casualFeedback;

    private PlayerStats playerStats;
    private DeliverFeedback deliverFeedback;

    public TextMeshProUGUI quarterText;
    public GameObject statistics;
    public GameObject buttonCanvas;

    private GameLoop gameLoop;

    private void Start()
    {
        playerStats = GetComponent<PlayerStats>();
        deliverFeedback = GetComponent<DeliverFeedback>();
        gameLoop = GetComponent<GameLoop>();
        //StartCoroutine("ActivateResultsCanvas");
    }

    public IEnumerator ActivateResultsCanvas()
    {
        quarterText.text = "Quarter " + gameLoop.getQuarterNum().ToString() + " Completed!";
        resultsCanvas.SetActive(true);
        source.PlayOneShot(fanfare);
        yield return new WaitForSeconds(2f);

        bossHappiness.text = "Boss Happiness: " + playerStats.getBossScore().ToString() + "/5";
        BossFeedback.text = deliverFeedback.getBossFeedback();

        sponsorshipSatisfaction.text = "Sponsorship Satisfaction: " + playerStats.getSponsorScore().ToString() + "/5";
        sponsorFeedback.text = deliverFeedback.getSponsorFeedback();

        publicInterest.text = "Public Interest: " + playerStats.getHypeScore().ToString() + "/5";
        crowdFeedback.text = deliverFeedback.getCrowdFeedback();

        esportViewCount.text = "Esports View Count: " + playerStats.getEsportsScore().ToString() + "/5";
        esportFeedback.text = deliverFeedback.getEsportsFeedback();

        casualInterest.text = "Casual Interest: " + playerStats.getFunScore().ToString() + "/5";
        casualFeedback.text = deliverFeedback.getCasualFeedback();

        statistics.SetActive(true);
        yield return new WaitForSeconds(2.55f);
        buttonCanvas.SetActive(true);

    }

    public void backToGame()
    {
        resultsCanvas.SetActive(false);
        statistics.SetActive(false);
        buttonCanvas.SetActive(false);
        //Start next round, or if quarter num is four go to final screen instead.
        gameLoop.roundStart();
    }
}
