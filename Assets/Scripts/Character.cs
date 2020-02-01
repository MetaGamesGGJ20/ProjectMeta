using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int desiredAttackSpeed = 3;
    public int desiredAttackPower = 3;
    public int desiredHealth = 3;
    public int desiredRange = 3;
    public int desiredMobility = 3;
    public int desiredLuck = 3;

    private int attackSpeed = 3;
    private int attackPower = 3;
    private int health = 3;
    private int range = 3;
    private int mobility = 3;
    private int luck = 3;

    private void Start()
    {
        randomizeStartValues();
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
