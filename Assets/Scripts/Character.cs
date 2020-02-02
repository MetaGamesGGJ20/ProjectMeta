using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
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
        return attackSpeed;
    }

    public int getAttackPower()
    {
        return attackPower;
    }

    public int getHealth()
    {
        return health;
    }

    public int getRange()
    {
        return range;
    }

    public int getMobility()
    {
        return mobility;
    }

    public int getLuck()
    {
        return luck;
    }

    public void incrementAttackSpeed()
    {
        if (attackSpeed < 5)
        {
            attackSpeed++;
        }
    }

    public void incrementAttackPower()
    {
        if (attackPower < 5)
        {
            attackPower++;
        }
    }

    public void incrementHealth()
    {
        if (health < 5)
        {
            health++;
        }
    }

    public void incrementRange()
    {
        if (range < 5)
        {
            range++;
        }
    }

    public void incrementMobility()
    {
        if (mobility < 5)
        {
            mobility++;
        }
    }

    public void incrementLuck()
    {
        if (luck < 5)
        {
            luck++;
        }
    }

    public void decrementAttackSpeed()
    {
        if (attackSpeed > 1)
        {
            attackSpeed--;
        }
    }

    public void decrementAttackPower()
    {
        if (attackPower > 1)
        {
            attackPower--;
        }
    }

    public void decrementHealth()
    {
        if (health > 1)
        {
            health--;
        }
    }

    public void decrementRange()
    {
        if (range > 1)
        {
            range--;
        }
    }

    public void decrementMobility()
    {
        if (mobility > 1)
        {
            mobility--;
        }
    }

    public void decrementLuck()
    {
        if (luck > 1)
        {
            luck--;
        }
    }

    public void setAttackSpeed(int stat)
    {
        attackSpeed = stat;
    }

    public void setAttackPower(int stat)
    {
        attackPower = stat;
    }

    public void setHealth(int stat)
    {
        health = stat;
    }

    public void setRange(int stat)
    {
        range = stat;
    }

    public void setMobility(int stat)
    {
        mobility = stat;
    }

    public void setLuck(int stat)
    {
        luck = stat;
    }

    public int getTotalScore()
    {
        return (attackSpeed + attackPower + health + range + mobility + luck);
    }
}
