﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DisplayWinOrLose : MonoBehaviour
{
    public GameObject resultsCanvas;
    public AudioClip fanfare;
    public AudioSource source;

    public TextMeshProUGUI bossHappiness;

    public TextMeshProUGUI sponsorshipSatisfaction;

    public TextMeshProUGUI publicInterest;

    public TextMeshProUGUI esportViewCount;

    public TextMeshProUGUI casualInterest;

    private PlayerStats playerStats;
    private DeliverFeedback deliverFeedback;

    public TextMeshProUGUI winLoseText;
    public GameObject statistics;
    public GameObject buttonCanvas;

    // references FadeOutEvent
    public GameObject fadeOut;

    private void Start()
    {
        playerStats = GetComponent<PlayerStats>();
        deliverFeedback = GetComponent<DeliverFeedback>();
        StartCoroutine("ActivateResultsCanvas");
    }

    IEnumerator ActivateResultsCanvas()
    {
        playerStats.updateScores();
        deliverFeedback.updateFeedback();
        if (playerStats.getBossScore() >= 4 && playerStats.getSponsorScore() >= 4 && playerStats.getHypeScore() >= 4 && playerStats.getEsportsScore() >= 4 && playerStats.getFunScore() >= 4)
        {
            winLoseText.text = "You Fixed Your Fighting Game!";
        }
        else
        {
            winLoseText.text = "Your game is still broken. You're Fired!";
        }
        resultsCanvas.SetActive(true);
        source.PlayOneShot(fanfare);
        yield return new WaitForSeconds(2f);

        bossHappiness.text = "Boss Happiness: " + playerStats.getBossScore().ToString() + "/5";
        sponsorshipSatisfaction.text = "Sponsorship Satisfaction: " + playerStats.getSponsorScore().ToString() + "/5";
        publicInterest.text = "Public Interest: " + playerStats.getHypeScore().ToString() + "/5";
        esportViewCount.text = "Esports View Count: " + playerStats.getEsportsScore().ToString() + "/5";
        casualInterest.text = "Casual Interest: " + playerStats.getFunScore().ToString() + "/5";

        statistics.SetActive(true);
        yield return new WaitForSeconds(2.55f);
        buttonCanvas.SetActive(true);

    }

    public void backToTitle()
    {
        fadeOut.SetActive(true); // initially set to false to avoid blocking raycast to start menu buttons
        fadeOut.GetComponent<FadeOutEvent>().StartFade();
        StartCoroutine(LoadGameWithFade());
    }

    // lets animation play out to transition to game, neccesary for coroutines
    IEnumerator LoadGameWithFade()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("StartMenu");
    }
}
