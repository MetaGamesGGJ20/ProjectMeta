using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PatchButtons : MonoBehaviour{
  public TextMeshPro budgetText;

  private int patchBudget = 50000;
  public int currentBudget = 50000;
  public int decrementValue = 5000;

    void Awake(){
      if(budgetText==null){
        Debug.LogError("Please attatched counter text object.");
      }
    }

    void Update(){
      if(currentBudget == 0)
      {
        endRound();
      }
      updateCounterGUI();
    }

    void updateCounterGUI(){
      budgetText.text = "$: " + currentBudget.ToString();
    }

    public void useBudget()
    {
        currentBudget -= decrementValue;
    }

    public void ResetBudget()
    {
        currentBudget = patchBudget;
    }

    void endRound(){

    }
}
