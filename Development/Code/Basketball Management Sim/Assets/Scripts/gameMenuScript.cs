using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameMenuScript : MonoBehaviour
{
    //Assign variables

    public Canvas buttonLayout;
    public Canvas homeScreen;
    public Canvas settingsScreen;
    public Canvas rosterScreen;
    public Canvas tradeScreen;
    public Canvas lineUpScreen;
    public Canvas standingsScreen;
    public Canvas statsScreen;
    public Canvas confirmQuit;
    public Canvas howToPlayScreen;
    public Canvas rosterDropdowns;
    public Canvas standingsDropdowns;
    public Canvas settingsDropDowns;

    public Button homeButton;
    public Button rosterButton;
    public Button standingsButton;
    public Button settingsButton;
    public Button quitButton;
    public Button continueButton;

    public Button yesQuit;
    public Button noQuit;
    public Button rosterView;
    public Button tradeFinder;
    public Button lineupEditor;
    public Button teamStats;
    public Button leagueRankings;
    public Button htpButton;
    public Button gameSettingsButton;

    public Button homeHelp;
    public Button rosterHelp;
    public Button standingsHelp;
    public Button generalHelp;

    public TMPro.TextMeshProUGUI generalText;
    public TMPro.TextMeshProUGUI rosterText;
    public TMPro.TextMeshProUGUI standingsText;
    public TMPro.TextMeshProUGUI homeText;



    public Toggle muteToggle;
    public Toggle fullScreenToggle;

    //public AudioSource bounceSound;



    // Start is called before the first frame update
    void Start()
    {
        //Assign variables to placeholders
        buttonLayout = buttonLayout.GetComponent<Canvas>();
        homeScreen = homeScreen.GetComponent<Canvas>();
        settingsScreen = settingsScreen.GetComponent<Canvas>();
        rosterScreen = rosterScreen.GetComponent<Canvas>();
        tradeScreen = tradeScreen.GetComponent<Canvas>();
        lineUpScreen = lineUpScreen.GetComponent<Canvas>();
        standingsScreen = standingsScreen.GetComponent<Canvas>();
        statsScreen = statsScreen.GetComponent<Canvas>();
        confirmQuit = confirmQuit.GetComponent<Canvas>();
        rosterDropdowns = rosterDropdowns.GetComponent<Canvas>();
        standingsDropdowns = standingsDropdowns.GetComponent<Canvas>();
        settingsDropDowns = settingsDropDowns.GetComponent<Canvas>();

        //bounceSound.GetComponent<AudioSource>();

        homeButton = homeButton.GetComponent<Button>();
        rosterButton = rosterButton.GetComponent<Button>();
        standingsButton = standingsButton.GetComponent<Button>();
        settingsButton = settingsButton.GetComponent<Button>();
        quitButton = quitButton.GetComponent<Button>();
        continueButton = continueButton.GetComponent<Button>();

        yesQuit = yesQuit.GetComponent<Button>();
        noQuit = noQuit.GetComponent<Button>();

        rosterView = rosterView.GetComponent<Button>();
        tradeFinder = tradeFinder.GetComponent<Button>();
        lineupEditor = lineupEditor.GetComponent<Button>();
        leagueRankings = leagueRankings.GetComponent<Button>();
        teamStats = teamStats.GetComponent<Button>();
        gameSettingsButton = gameSettingsButton.GetComponent<Button>();
        htpButton = htpButton.GetComponent<Button>();
       

        muteToggle = muteToggle.GetComponent<Toggle>();
        fullScreenToggle = fullScreenToggle.GetComponent<Toggle>();

        homeHelp = homeHelp.GetComponent<Button>();
        rosterHelp = rosterHelp.GetComponent<Button>();
        generalHelp = generalHelp.GetComponent<Button>();
        standingsHelp = standingsHelp.GetComponent<Button>();

        generalText = generalText.GetComponent<TMPro.TextMeshProUGUI>();
        rosterText = rosterText.GetComponent<TMPro.TextMeshProUGUI>();
        standingsText = standingsText.GetComponent<TMPro.TextMeshProUGUI>();
        homeText = homeText.GetComponent<TMPro.TextMeshProUGUI>();


        //Set the default screen

        buttonLayout.enabled = true;
        homeScreen.enabled = true;
        settingsScreen.enabled = false;
        rosterScreen.enabled = false;
        lineUpScreen.enabled = false;
        tradeScreen.enabled = false;
        standingsScreen.enabled = false;
        statsScreen.enabled = false;
        confirmQuit.enabled = false;
        howToPlayScreen.enabled = false;
        rosterDropdowns.enabled = false;
        standingsDropdowns.enabled = false;
        generalText.enabled = true;
        rosterText.enabled = false;
        standingsText.enabled = false;
        homeText.enabled = false;

    }

    //Go to home page
    public void homePress()
    {
        buttonLayout.enabled = true;
        homeScreen.enabled = true;
        rosterScreen.enabled = false;
        settingsScreen.enabled = false;
        lineUpScreen.enabled = false;

        lineUpScreen.enabled = false;
        howToPlayScreen.enabled = false;

        tradeScreen.enabled = false;
        standingsScreen.enabled = false;
        statsScreen.enabled = false;
        rosterDropdowns.enabled = false;
        standingsDropdowns.enabled = false;
        settingsDropDowns.enabled = false;
    }

    //Quit the game
    public void quitPress()
    {
        confirmQuit.enabled = true;
    }

    //Confirm Quit
    public void quitYes()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void quitNo()
    {
        confirmQuit.enabled = false;

    }



    //Settings dropdown
    public void settingsPress()
    {
        settingsDropDowns.enabled = !settingsDropDowns.enabled;
        rosterDropdowns.enabled = false;
        standingsDropdowns.enabled = false;

    }    
    //Settings screen
    public void gameSettingsPress()
    {
        settingsScreen.enabled = true;
        settingsDropDowns.enabled = false;
        homeScreen.enabled = false;
        rosterScreen.enabled = false;
        tradeScreen.enabled = false;
        standingsScreen.enabled = false;
        statsScreen.enabled = false;
        confirmQuit.enabled = false;
        lineUpScreen.enabled = false;
        howToPlayScreen.enabled = false;


    }    //How To Play screen
    public void howtoplayPress()
    {
        howToPlayScreen.enabled = true;
        settingsDropDowns.enabled = false; 
        settingsScreen.enabled = false;
        homeScreen.enabled = false;
        rosterScreen.enabled = false;
        tradeScreen.enabled = false;
        standingsScreen.enabled = false;
        statsScreen.enabled = false;
        confirmQuit.enabled = false;
        lineUpScreen.enabled = false;

    }

    //Open roster management dropdown
    public void rosterPress()
    {
        rosterDropdowns.enabled = !rosterDropdowns.enabled;
        standingsDropdowns.enabled = false;
        settingsDropDowns.enabled = false;

    }
    //Go to roster screen
    public void rosterViewPress()
    {
        rosterScreen.enabled = true;
        rosterDropdowns.enabled = false;
        standingsDropdowns.enabled = false;
        homeScreen.enabled = false;
        settingsScreen.enabled = false;
        lineUpScreen.enabled = false;

        tradeScreen.enabled = false;
        standingsScreen.enabled = false;
        statsScreen.enabled = false;
        confirmQuit.enabled = false;
        howToPlayScreen.enabled = false;

    }
    //Go to trade finder screen
    public void tradeFinderPress()
    {
        tradeScreen.enabled = true;
        lineUpScreen.enabled = false;
        rosterDropdowns.enabled = false;
        standingsDropdowns.enabled = false;
        homeScreen.enabled = false;
        settingsScreen.enabled = false;
        rosterScreen.enabled = false;
        standingsScreen.enabled = false;
        statsScreen.enabled = false;
        confirmQuit.enabled = false;
        howToPlayScreen.enabled = false;

    }
    //Go to lineup editor screen
    public void lineupPress()
    {
        lineUpScreen.enabled = true;
        tradeScreen.enabled = false;
        rosterDropdowns.enabled = false;
        standingsDropdowns.enabled = false;
        homeScreen.enabled = false;
        settingsScreen.enabled = false;
        rosterScreen.enabled = false;
        standingsScreen.enabled = false;
        statsScreen.enabled = false;
        confirmQuit.enabled = false;
        howToPlayScreen.enabled = false;

    }



    //Open team standings dropdown
    public void standingsPress()
    {

        standingsDropdowns.enabled = !standingsDropdowns.enabled;
        rosterDropdowns.enabled = false;
        settingsDropDowns.enabled = false;
    }

    //Go to stats page
    public void teamStatsPress()
    {
        statsScreen.enabled = true;
        standingsDropdowns.enabled = false;
        rosterDropdowns.enabled = false;
        homeScreen.enabled = false;
        settingsScreen.enabled = false;
        rosterScreen.enabled = false;
        tradeScreen.enabled = false;
        standingsScreen.enabled = false;
        confirmQuit.enabled = false;
        lineUpScreen.enabled = false;
        howToPlayScreen.enabled = false;

    }
    //Go to standings page
    public void leagueStandingsPress()
    {
        standingsScreen.enabled = true;
        standingsDropdowns.enabled = false;
        rosterDropdowns.enabled = false;
        homeScreen.enabled = false;
        settingsScreen.enabled = false;
        rosterScreen.enabled = false;
        tradeScreen.enabled = false;
        statsScreen.enabled = false;
        confirmQuit.enabled = false;
        lineUpScreen.enabled = false;
        howToPlayScreen.enabled = false;

    }


    //How to play screen accessed through settings
    public void htpPress()
    {
        howToPlayScreen.enabled = true;
        settingsScreen.enabled = false;
    }

    //Close the HTP menu
    public void closeHTP()
    {
        settingsScreen.enabled = true;
        howToPlayScreen.enabled = false;
    }

    //Mute game sound
    public void mute()
    {
        if (AudioListener.pause == true)
        { AudioListener.pause = false; }
        else AudioListener.pause = true;
    }

    //Toggle fullscreen
    public void fullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        if (Screen.fullScreen)
        { print("Full Screen on"); }
        else if (Screen.fullScreen == false)
        { print("Full Screen off"); }
    }
    //At end of game, quit button
    public void endGameQuit()
    {
        SceneManager.LoadScene("Main Menu");

    }
    //End of game replay button
    public void endGameReplay()
    {
        SceneManager.LoadScene("Game");

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
