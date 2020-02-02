using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FightSceneManager : MonoBehaviour {

    void Awake(){
        
    }

    void fightTime(){
        StartCoroutine(FightTimeBeforeResultScreen());
    }

    IEnumerator FightTimeBeforeResultScreen(){
        yield return new WaitForSeconds(5f);
        // FightSceneManager.LoadScene("");
    }
}
