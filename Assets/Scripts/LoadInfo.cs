using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadInfo : MonoBehaviour
{
    private DeliverFeedback feedback;
    private PlayerStats playerStats;

    public Character mcChar;
    public Character grapplerChar;
    public Character zonerChar;
    public Character hypeChar;
    public Character techChar;

    public TextMeshProUGUI[] mcProperties;
    public TextMeshProUGUI[] grapplerProperties;
    public TextMeshProUGUI[] zonerProperties;
    public TextMeshProUGUI[] hypeProperties;
    public TextMeshProUGUI[] techProperties;

    public TextMeshProUGUI[] bossHappiness;
    public TextMeshProUGUI[] sponsorSatifisfaction;
    public TextMeshProUGUI[] publicInterest;
    public TextMeshProUGUI[] esportsViewCount;
    public TextMeshProUGUI[] casualInterest;

    public TextMeshProUGUI bossFeedback;
    public TextMeshProUGUI sponsorFeedback;
    public TextMeshProUGUI publicFeedback;
    public TextMeshProUGUI esportsFeedback;
    public TextMeshProUGUI casualFeedback;

    // Start is called before the first frame update
    void Start()
    {
        feedback = GetComponent<DeliverFeedback>();
        playerStats = GetComponent<PlayerStats>();
    }

    private void Update()
    {
        LoadFeedback();
        LoadPlayerStats();
        LoadCharStats();
    }

    private void LoadFeedback()
    {
        bossFeedback.text = feedback.getBossFeedback();
        sponsorFeedback.text = feedback.getSponsorFeedback();
        publicFeedback.text = feedback.getCrowdFeedback();
        esportsFeedback.text = feedback.getEsportsFeedback();
        casualFeedback.text = feedback.getCasualFeedback();
    }

    private void LoadPlayerStats()
    {
        for(int i = 0; i < 2; i++)
        {
            bossHappiness[i].text = "B: " + playerStats.getBossScore();
            sponsorSatifisfaction[i].text = "S: " + playerStats.getSponsorScore();
            publicInterest[i].text = "P: " + playerStats.getHypeScore();
            esportsViewCount[i].text = "E: " + playerStats.getEsportsScore();
            casualInterest[i].text = "C: " + playerStats.getFunScore();
        }
    }

    private void LoadCharStats()
    {
        mcProperties[0].text = mcChar.getAttackSpeed().ToString();
        grapplerProperties[0].text = grapplerChar.getAttackSpeed().ToString();
        hypeProperties[0].text = hypeChar.getAttackSpeed().ToString();
        techProperties[0].text = techChar.getAttackSpeed().ToString();
        zonerProperties[0].text = zonerChar.getAttackSpeed().ToString();

        mcProperties[1].text = mcChar.getAttackPower().ToString();
        grapplerProperties[1].text = grapplerChar.getAttackPower().ToString();
        hypeProperties[1].text = hypeChar.getAttackPower().ToString();
        techProperties[1].text = techChar.getAttackPower().ToString();
        zonerProperties[1].text = zonerChar.getAttackPower().ToString();

        mcProperties[2].text = mcChar.getHealth().ToString();
        grapplerProperties[2].text = grapplerChar.getHealth().ToString();
        hypeProperties[2].text = hypeChar.getHealth().ToString();
        techProperties[2].text = techChar.getHealth().ToString();
        zonerProperties[2].text = zonerChar.getHealth().ToString();

        mcProperties[3].text = mcChar.getMobility().ToString();
        grapplerProperties[3].text = grapplerChar.getMobility().ToString();
        hypeProperties[3].text = hypeChar.getMobility().ToString();
        techProperties[3].text = techChar.getMobility().ToString();
        zonerProperties[3].text = zonerChar.getMobility().ToString();

        mcProperties[4].text = mcChar.getRange().ToString();
        grapplerProperties[4].text = grapplerChar.getRange().ToString();
        hypeProperties[4].text = hypeChar.getRange().ToString();
        techProperties[4].text = techChar.getRange().ToString();
        zonerProperties[4].text = zonerChar.getRange().ToString();

        mcProperties[5].text = mcChar.getLuck().ToString();
        grapplerProperties[5].text = grapplerChar.getLuck().ToString();
        hypeProperties[5].text = hypeChar.getLuck().ToString();
        techProperties[5].text = techChar.getLuck().ToString();
        zonerProperties[5].text = zonerChar.getLuck().ToString();
    }
}
