using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PatchButtons : MonoBehaviour{
  public TextMeshPro counter;

  public int budget = 50000;
  public int decrementValue = 5000;

    void Awake(){
      if(counter==null){
        Debug.LogError("Please attatched counter text object.");
      }
    }

    void Update(){
      if(budget==0){
        endRound();
      }
      updateCounterGUI();
    }

    void updateCounterGUI(){
      counter.text = budget.ToString();
    }

    public void useBudget(){
      budget = budget - decrementValue;
    }

    void endRound(){

    }
}
