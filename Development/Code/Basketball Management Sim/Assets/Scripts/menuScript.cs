using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    //Assign variables

    public Canvas mainMenu;
    public Canvas howToPlay;
    public Canvas settingsScreen;
    public Canvas quitScreen;

    public Button backToMain;
    public Button startButton;
    public Button settingsButton;
    public Button HTPButton;
    public Button closeHTPButton;
    public Button quitButton;
    public Button yesQuitButton;
    public Button noQuitButton;

    public Toggle muteToggle;
    public Toggle fullScreenToggle;

    public AudioSource bounceSound;

    public Button homeHelp;
    public Button rosterHelp;
    public Button standingsHelp;
    public Button generalHelp;

    public TMPro.TextMeshProUGUI generalText;
    public TMPro.TextMeshProUGUI rosterText;
    public TMPro.TextMeshProUGUI standingsText;
    public TMPro.TextMeshProUGUI homeText;


    // Start is called before the first frame update
    void Start()
    {
        //Get component for each object, allows functions to be performed on them
        mainMenu = mainMenu.GetComponent<Canvas>();
        settingsScreen = settingsScreen.GetComponent<Canvas>();
        howToPlay = howToPlay.GetComponent<Canvas>();
        quitScreen = quitScreen.GetComponent<Canvas>();

        bounceSound.GetComponent<AudioSource>();

        startButton = startButton.GetComponent<Button>();
        settingsButton = settingsButton.GetComponent<Button>();
        HTPButton = HTPButton.GetComponent<Button>();
        closeHTPButton = closeHTPButton.GetComponent<Button>();
        quitButton = quitButton.GetComponent<Button>();
        backToMain = backToMain.GetComponent<Button>();

        muteToggle = muteToggle.GetComponent<Toggle>();
        fullScreenToggle = fullScreenToggle.GetComponent<Toggle>();


        //Set the default screen
        mainMenu.enabled = true;
        settingsScreen.enabled = false;
        quitScreen.enabled = false;
        howToPlay.enabled = false;

        homeHelp = homeHelp.GetComponent<Button>();
        rosterHelp = rosterHelp.GetComponent<Button>();
        generalHelp = generalHelp.GetComponent<Button>();
        standingsHelp = standingsHelp.GetComponent<Button>();

        generalText = generalText.GetComponent<TMPro.TextMeshProUGUI>();
        rosterText = rosterText.GetComponent<TMPro.TextMeshProUGUI>();
        standingsText = standingsText.GetComponent<TMPro.TextMeshProUGUI>();
        homeText = homeText.GetComponent<TMPro.TextMeshProUGUI>();

        generalText.enabled = true;
        rosterText.enabled = false;
        standingsText.enabled = false;
        homeText.enabled = false;
    }

    //Start the game
    public void startPress()
    {
        bounceSound.Play();
        //Load game scene
        SceneManager.LoadScene("Game");

    }

    //Quit the game
    public void quitPress()
    {
        //Bring up the quit confirmation screen
        quitScreen.enabled = true;
        mainMenu.enabled = false;

    }

    //Confirm Quit
    public void quitYes()
    {
        Application.Quit();
    }
    public void quitNo()
    {
        quitScreen.enabled = false;
        mainMenu.enabled = true;
    }



    //Settings screen
    public void settingsPress()
    {

        settingsScreen.enabled = true;
        mainMenu.enabled = false;
        quitScreen.enabled = false;

    }
    
    //Return to main screen
    public void backToMainMenu()
    {

        mainMenu.enabled = true;
        settingsScreen.enabled = false;
        quitScreen.enabled = false;
        howToPlay.enabled = false;

    }


    //How to play screen accessed through settings
    public void howToPlayPress()
    {
        howToPlay.enabled = true;
        settingsScreen.enabled = false;
    }

    //Close the HTP menu
    public void closeHTP()
    {
        settingsScreen.enabled = true;
        howToPlay.enabled = false;
    }

    //Mute game sound
    public void mute()
    {
        //Toggle the sound on or off
        if (AudioListener.pause == true)
        { AudioListener.pause = false; }
        else AudioListener.pause = true;
    }

    public void fullScreen()
    {
        //If full screen is on, turn it off, if off, turn it on
        Screen.fullScreen = !Screen.fullScreen;
        if (Screen.fullScreen)
        { print("Full Screen on"); }
        else if (Screen.fullScreen == false)
        { print("Full Screen off"); }
    }
    public void generalHelpButton()
    {
        generalText.enabled = true;
        rosterText.enabled = false;
        standingsText.enabled = false;
        homeText.enabled = false;
    }

    public void rosterHelpButton()
    {
        generalText.enabled = false;
        rosterText.enabled = true;
        standingsText.enabled = false;
        homeText.enabled = false;
    }

    public void standingsHelpButton()
    {
        generalText.enabled = false;
        rosterText.enabled = false;
        standingsText.enabled = true;
        homeText.enabled = false;
    }

    public void homeHelpButton()
    {
        generalText.enabled = false;
        rosterText.enabled = false;
        standingsText.enabled = false;
        homeText.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
