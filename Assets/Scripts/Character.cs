using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public BudgetManagement budget;

    public string characterName;
    public int desiredAttackSpeed = 3;
    public int desiredAttackPower = 3;
    public int desiredHealth = 3;
    public int desiredRange = 3;
    public int desiredMobility = 3;
    public int desiredLuck = 3;

    public string[] attributes = new string[] { "Attack Speed", "Attack Power", "Health", "Range", "Mobility", "Luck" };

    private int attackSpeed = 3;
    private int attackPower = 3;
    private int health = 3;
    private int range = 3;
    private int mobility = 3;
    private int luck = 3;

    private int roundAS;
    private int roundAP;
    private int roundH;
    private int roundR;
    private int roundM;
    private int roundL;

    private void Start()
    {
        randomizeStartValues();
        setRoundValues();
    }

    private void randomizeStartValues()
    {
        attackSpeed = Random.Range(1, 5);
        attackPower = Random.Range(1, 5);
        health = Random.Range(1, 5);
        range = Random.Range(1, 5);
        mobility = Random.Range(1, 5);
        luck = Random.Range(1, 5);
    }

    //called to reverse changes
    public void setRoundValues()
    {
        roundAS = attackSpeed;
        roundAP = attackPower;
        roundH = health;
        roundR = range;
        roundM = mobility;
        roundL = luck;
    }

    //called after each round
    public void updateCharValues()
    {
        attackSpeed = roundAS;
        attackPower = roundAP;
        health = roundH;
        range = roundR;
        mobility = roundM;
        luck = roundL;
    }

    public int getAttackSpeed()
    {
        return roundAS;
    }

    public int getAttackPower()
    {
        return roundAP;
    }

    public int getHealth()
    {
        return roundH;
    }

    public int getRange()
    {
        return roundR;
    }

    public int getMobility()
    {
        return roundM;
    }

    public int getLuck()
    {
        return roundL;
    }

    public void incrementAttackSpeed()
    {
        if (roundAS < 5 && budget.currentBudget > 0)
        {
            roundAS++;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void incrementAttackPower()
    {
        if (roundAP < 5 && budget.currentBudget > 0)
        {
            roundAP++;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void incrementHealth()
    {
        if (roundH < 5 && budget.currentBudget > 0)
        {
            roundH++;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void incrementRange()
    {
        if (roundR < 5 && budget.currentBudget > 0)
        {
            roundR++;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void incrementMobility()
    {
        if (roundM < 5 && budget.currentBudget > 0)
        {
            roundM++;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void incrementLuck()
    {
        if (roundL < 5 && budget.currentBudget > 0)
        {
            roundL++;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void decrementAttackSpeed()
    {
        if (roundAS > 1 && budget.currentBudget > 0)
        {
            roundAS--;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void decrementAttackPower()
    {
        if (roundAP > 1 && budget.currentBudget > 0)
        {
            roundAP--;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void decrementHealth()
    {
        if (roundH > 1 && budget.currentBudget > 0)
        {
            roundH--;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void decrementRange()
    {
        if (roundR > 1 && budget.currentBudget > 0)
        {
            roundR--;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void decrementMobility()
    {
        if (roundM > 1 && budget.currentBudget > 0)
        {
            roundM--;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void decrementLuck()
    {
        if (roundL > 1 && budget.currentBudget > 0)
        {
            roundL--;
            budget.currentBudget -= budget.decrementValue;
        }
    }

    public void setAttackSpeed(int stat)
    {
        roundAS = stat;
    }

    public void setAttackPower(int stat)
    {
        roundAP = stat;
    }

    public void setHealth(int stat)
    {
        roundH = stat;
    }

    public void setRange(int stat)
    {
        roundR = stat;
    }

    public void setMobility(int stat)
    {
        roundM = stat;
    }

    public void setLuck(int stat)
    {
        roundL = stat;
    }

    public int getTotalScore()
    {
        return (roundAS + roundAP + roundH + roundR + roundM + roundL);
    }
}
