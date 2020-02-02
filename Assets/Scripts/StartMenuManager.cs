using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour {
  // references to button objects
  public Button startButton;
  public Button settingsButton;
  public Button exitButton;
  public Button backButton;

  // references to Submenus
  public GameObject mainMenu;
  public GameObject settingsMenu;

  public AudioMixer audioMixer;

  // references FadeOutEvent
  public GameObject fadeOut;

  void Awake(){
    if(mainMenu==null || settingsMenu==null || fadeOut==null){
      Debug.LogError("Must attatched Main menu canvas and or settings canvas");
    }

    ShowMenu("Main");

    // setup the listener to StartGame when clicked
    startButton.onClick.RemoveAllListeners();
    startButton.onClick.AddListener(() => StartGame());

    // setup the listener to Show settings Screen when clicked
    settingsButton.onClick.RemoveAllListeners();
    settingsButton.onClick.AddListener(() => ShowMenu("Settings"));

    // setup the listener to Show the main menu screen when clicked
    backButton.onClick.RemoveAllListeners();
    backButton.onClick.AddListener(() => ShowMenu("Main"));

    // setup the listener to exit the game;
    exitButton.onClick.RemoveAllListeners();
    exitButton.onClick.AddListener(() => Quit());
  }

  // handles navigation between menus
  public void ShowMenu(string menuName){
    // all menus off by default until selected
    mainMenu.SetActive(false);
    settingsMenu.SetActive(false);

    // switches to menu that is selected
    switch(menuName){
      case "Main":
        mainMenu.SetActive(true);
        break;
      case "Settings":
        settingsMenu.SetActive(true);
        break;
    }
  }

  // Starts game, with fade to black effect
  public void StartGame(){
    fadeOut.SetActive(true); // initially set to false to avoid blocking raycast to start menu buttons
    fadeOut.GetComponent<FadeOutEvent>().StartFade();
    StartCoroutine(LoadGameWithFade());
  }

  // handles setting up volume Settings
  public void SetVolume(float volume){
    audioMixer.SetFloat("volume", volume);
  }


  // Self explanatory
  public void Quit(){
    Application.Quit();
  }

  // lets animation play out to transition to game, neccesary for coroutines
  IEnumerator LoadGameWithFade() {
    yield return new WaitForSeconds(1f);
    SceneManager.LoadScene("GameScene");
  }
}
