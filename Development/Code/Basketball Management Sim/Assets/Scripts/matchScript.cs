using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matchScript : MonoBehaviour
{
    //Assign variables
    public GameObject home;
    public GameObject match;
    public GameObject winnerScreen;
    public GameObject loserScreen;
    public rosterScript roster;
    public TMPro.TextMeshProUGUI opponentTeamName;
    public TMPro.TextMeshProUGUI oppOffRtg;
    public TMPro.TextMeshProUGUI oppDefRtg;
    public TMPro.TextMeshProUGUI oppOvrRtg;
    public TMPro.TextMeshProUGUI oppRecord;
    public TMPro.TextMeshProUGUI oppKeyPlayer1;
    public TMPro.TextMeshProUGUI oppKeyPlayer2;
    public TMPro.TextMeshProUGUI oppKeyPlayer3;    
    public TMPro.TextMeshProUGUI oppKeyPlayer1Rating;
    public TMPro.TextMeshProUGUI oppKeyPlayer2Rating;
    public TMPro.TextMeshProUGUI oppKeyPlayer3Rating;

    public TMPro.TextMeshProUGUI opponentTeamName2;
    public TMPro.TextMeshProUGUI homeStarter1;
    public TMPro.TextMeshProUGUI homeStarter2;
    public TMPro.TextMeshProUGUI homeStarter3;
    public TMPro.TextMeshProUGUI homeStarter4;
    public TMPro.TextMeshProUGUI homeStarter5;    
    public TMPro.TextMeshProUGUI awayStarter1;
    public TMPro.TextMeshProUGUI awayStarter2;
    public TMPro.TextMeshProUGUI awayStarter3;
    public TMPro.TextMeshProUGUI awayStarter4;
    public TMPro.TextMeshProUGUI awayStarter5;


    public TMPro.TextMeshProUGUI homeScore1;
    public TMPro.TextMeshProUGUI homeScore2;
    public TMPro.TextMeshProUGUI homeScore3;
    public TMPro.TextMeshProUGUI homeScore4;    
    public TMPro.TextMeshProUGUI awayScore1;
    public TMPro.TextMeshProUGUI awayScore2;
    public TMPro.TextMeshProUGUI awayScore3;
    public TMPro.TextMeshProUGUI awayScore4;
    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI awayScoreName;

    public TMPro.TextMeshProUGUI currentRecord;
    public TMPro.TextMeshProUGUI homeScreenOffense;
    public TMPro.TextMeshProUGUI homeScreenDefence;
    public TMPro.TextMeshProUGUI homeScreenOvr;
    public TMPro.TextMeshProUGUI homeKeyPlayer;
    public TMPro.TextMeshProUGUI homeKPRating;

    public TMPro.TextMeshProUGUI winningTeamName;

    public Button playButton;
    public Button returnToHomeButton;
    public Image scoreBreakdown;

    public int gameNumber;
    //public int quarter;
    public List<string> teamNames = new List<string>() { "London", "Paris", "Madrid", "Milan", "Wien", "Berlin", "Dublin", "Oslo", "Budapest", "Lisbon" };
    public bool firstTime;

    public string keyPlayer1Name;
    public string keyPlayer2Name;
    public string keyPlayer3Name;
    public string homeKeyPlayerName;

    public int keyPlayer1Rating;
    public int keyPlayer2Rating;
    public int keyPlayer3Rating;
    public int homeKeyPlayerRating;
    public int firstPlayer;
    public int homeScore;
    public int homeQuarterScore;
    public int awayScore;
    public int awayQuarterScore;
    public int homeOffawayDef;
    public int homeDefawayOff;
    public int simHomeTeam;
    public int simHomePoints;
    public int simAwayTeam;
    public int simAwayPoints;
    public int nextMatch;

    public int homeInsideScoring;
    public int homeOutsideScoring;
    public int homeInsideDefence;
    public int homePerimeterDefence;    
    
    public int awayInsideScoring;
    public int awayOutsideScoring;
    public int awayInsideDefence;
    public int awayPerimeterDefence;

    public int homeOutAwayPerim;
    public int homeInAwayIn;
    public int awayOutHomePerim;
    public int awayInHomeIn;

    public string leagueWinner;

    //Create random number generator
    System.Random rnd = new System.Random();


    // Start is called before the first frame update
    void Start()
    {
        //Assign variables to placeholders
        opponentTeamName = opponentTeamName.GetComponent<TMPro.TextMeshProUGUI>();
        opponentTeamName2 = opponentTeamName2.GetComponent<TMPro.TextMeshProUGUI>();
        oppOffRtg = oppOffRtg.GetComponent<TMPro.TextMeshProUGUI>();
        oppDefRtg = oppDefRtg.GetComponent<TMPro.TextMeshProUGUI>();
        oppOvrRtg = oppOvrRtg.GetComponent<TMPro.TextMeshProUGUI>();
        oppRecord = oppRecord.GetComponent<TMPro.TextMeshProUGUI>();
        oppKeyPlayer1 = oppKeyPlayer1.GetComponent<TMPro.TextMeshProUGUI>();
        oppKeyPlayer2 = oppKeyPlayer2.GetComponent<TMPro.TextMeshProUGUI>();
        oppKeyPlayer3 = oppKeyPlayer3.GetComponent<TMPro.TextMeshProUGUI>();        
        oppKeyPlayer1Rating = oppKeyPlayer1Rating.GetComponent<TMPro.TextMeshProUGUI>();
        oppKeyPlayer2Rating = oppKeyPlayer2Rating.GetComponent<TMPro.TextMeshProUGUI>();
        oppKeyPlayer3Rating = oppKeyPlayer3Rating.GetComponent<TMPro.TextMeshProUGUI>();

        homeStarter1 = homeStarter1.GetComponent<TMPro.TextMeshProUGUI>();
        homeStarter2 = homeStarter2.GetComponent<TMPro.TextMeshProUGUI>();
        homeStarter3 = homeStarter3.GetComponent<TMPro.TextMeshProUGUI>();
        homeStarter4 = homeStarter4.GetComponent<TMPro.TextMeshProUGUI>();
        homeStarter5 = homeStarter5.GetComponent<TMPro.TextMeshProUGUI>();
        awayStarter1 = awayStarter1.GetComponent<TMPro.TextMeshProUGUI>();
        awayStarter2 = awayStarter2.GetComponent<TMPro.TextMeshProUGUI>();
        awayStarter3 = awayStarter3.GetComponent<TMPro.TextMeshProUGUI>();
        awayStarter4 = awayStarter4.GetComponent<TMPro.TextMeshProUGUI>();
        awayStarter5 = awayStarter5.GetComponent<TMPro.TextMeshProUGUI>();

        scoreText = scoreText.GetComponent<TMPro.TextMeshProUGUI>();

        homeScore1 = homeScore1.GetComponent<TMPro.TextMeshProUGUI>();
        homeScore2 = homeScore2.GetComponent<TMPro.TextMeshProUGUI>();
        homeScore3 = homeScore3.GetComponent<TMPro.TextMeshProUGUI>();
        homeScore4 = homeScore4.GetComponent<TMPro.TextMeshProUGUI>();        
        awayScore1 = awayScore1.GetComponent<TMPro.TextMeshProUGUI>();
        awayScore2 = awayScore2.GetComponent<TMPro.TextMeshProUGUI>();
        awayScore3 = awayScore3.GetComponent<TMPro.TextMeshProUGUI>();
        awayScore4 = awayScore4.GetComponent<TMPro.TextMeshProUGUI>();
        awayScoreName = awayScoreName.GetComponent<TMPro.TextMeshProUGUI>();

        playButton = playButton.GetComponent<Button>();
        returnToHomeButton = returnToHomeButton.GetComponent<Button>();

        homeKeyPlayer = homeKeyPlayer.GetComponent<TMPro.TextMeshProUGUI>();
        homeKPRating = homeKPRating.GetComponent<TMPro.TextMeshProUGUI>();
        homeScreenOffense = homeScreenOffense.GetComponent<TMPro.TextMeshProUGUI>();
        homeScreenDefence = homeScreenDefence.GetComponent<TMPro.TextMeshProUGUI>();
        homeScreenOvr = homeScreenOvr.GetComponent<TMPro.TextMeshProUGUI>();
        currentRecord = currentRecord.GetComponent<TMPro.TextMeshProUGUI>();


        winningTeamName = winningTeamName.GetComponent<TMPro.TextMeshProUGUI>();

        //Default game number to 1
        gameNumber = 1;
        firstTime = true;
        match.SetActive(false);
        winnerScreen.SetActive(false);
        loserScreen.SetActive(false);
        home.SetActive(true);
        playButton.gameObject.SetActive(true);
        returnToHomeButton.gameObject.SetActive(false);
        firstPlayer = 10;
    }

    // Update is called once per frame
    void Update()
    {
           //If game is run for first time, update the home screen to show all details after roster generation
        if (firstTime == true)
        {
            updateHomeScreen();
            firstTime = false;
        }
        //Check if league is finished
        if (gameNumber == 10)
        {
            endOfSeason();
        }


    }
    //Update the home screen after a match
    public void updateHomeScreen()
    {

        //Print home record
        currentRecord.text = ($"{roster.teamWins[0]} - {roster.teamLosses[0]}");
        //Show next opponents details
        opponentTeamName.text = teamNames[gameNumber];
        oppOffRtg.text = roster.teamOffense[gameNumber].ToString();
        oppDefRtg.text = roster.teamDefence[gameNumber].ToString();
        oppOvrRtg.text = roster.teamOvr[gameNumber].ToString();
        oppRecord.text = ($"{roster.teamWins[gameNumber]} - {roster.teamLosses[gameNumber]}");
        //Show home team ratings
        homeScreenOffense.text = roster.teamOffense[0].ToString();
        homeScreenDefence.text = roster.teamDefence[0].ToString();
        homeScreenOvr.text = roster.teamOvr[0].ToString();
        homeKeyPlayerCalc();
        calcKeyPlayers();

    }
    //Calculate the key players for the opposing team in next match
    public void calcKeyPlayers()
    {
        //Default values
        int keyPlayer1=0;
        int keyPlayer2=0;
        int keyPlayer3=0;
        int startingNumber = 0;

        keyPlayer1Rating = 0;
        keyPlayer2Rating = 0;
        keyPlayer3Rating = 0;
        //Depending on game number, set the value that the key player finder should start from
        if (gameNumber == 1)
        {
            startingNumber = 10;
        }        
        if (gameNumber == 2)
        {
            startingNumber = 20;
        }        
        if (gameNumber == 3)
        {
            startingNumber = 30;
        }        
        if (gameNumber == 4)
        {
            startingNumber = 40;
        }
        if (gameNumber == 5)
        {
            startingNumber = 50;
        }
        if (gameNumber == 6)
        {
            startingNumber = 60;
        }
        if (gameNumber == 7)
        {
            startingNumber = 70;
        }
        if (gameNumber == 8)
        {
            startingNumber = 80;
        }
        if (gameNumber == 9)
        {
            startingNumber = 90;
        }
        //Set last player to check
        int lastNumber = startingNumber + 10;
        //Check through the team and assign the key players to the placeholders
        for (int i= startingNumber; i != lastNumber; i++)
        {
            //If higher rated, take that players space and move each player down one slot
            if (roster.ovrRtg[i] >= keyPlayer1Rating)
            {
                keyPlayer3Rating = keyPlayer2Rating;
                keyPlayer2Rating = keyPlayer1Rating;
                keyPlayer1Rating = roster.ovrRtg[i];
                keyPlayer3 = keyPlayer2;
                keyPlayer2 = keyPlayer1;
                keyPlayer1 = i;

            }
            else if (roster.ovrRtg[i] >= keyPlayer2Rating)
            {
                keyPlayer3Rating = keyPlayer2Rating;
                keyPlayer2Rating = roster.ovrRtg[i];
                keyPlayer3 = keyPlayer2;
                keyPlayer2 = i;
            }
            else if (roster.ovrRtg[i] >= keyPlayer1Rating)
            {
                keyPlayer3Rating = roster.ovrRtg[i];
                keyPlayer3 = i;
            }
        }
        //Present details on screen
        oppKeyPlayer1.text = roster.playerNames[keyPlayer1];
        oppKeyPlayer2.text = roster.playerNames[keyPlayer2];
        oppKeyPlayer3.text = roster.playerNames[keyPlayer3];
        oppKeyPlayer1Rating.text = keyPlayer1Rating.ToString();
        oppKeyPlayer2Rating.text = keyPlayer2Rating.ToString();
        oppKeyPlayer3Rating.text = keyPlayer3Rating.ToString();
    }


    //When you enter a match run this script
    public void matchScreen()
    {
        //Set match screen to active
        home.SetActive(false);
        match.SetActive(true);
        playButton.gameObject.SetActive(true);
        returnToHomeButton.gameObject.SetActive(false);
        scoreBreakdown.gameObject.SetActive(false);

        //Default score to 0-0
        scoreText.text = "0 - 0";
        //Show match details, player names, team name etc
        opponentTeamName2.text = opponentTeamName.text;
        homeStarter1.text= roster.playerNames[0];
        homeStarter2.text= roster.playerNames[1];
        homeStarter3.text= roster.playerNames[2];
        homeStarter4.text= roster.playerNames[3];
        homeStarter5.text= roster.playerNames[4];
        //Find the starting 5 for opponent
        if (gameNumber == 1)
        {
            firstPlayer = 10;
        }
        if (gameNumber == 2)
        {
            firstPlayer = 20;
        }
        if (gameNumber == 3)
        {
            firstPlayer = 30;
        }
        if (gameNumber == 4)
        {
            firstPlayer = 40;
        }
        if (gameNumber == 5)
        {
            firstPlayer = 50;
        }
        if (gameNumber == 6)
        {
            firstPlayer = 60;
        }
        if (gameNumber == 7)
        {
            firstPlayer = 70;
        }
        if (gameNumber == 8)
        {
            firstPlayer = 80;
        }
        if (gameNumber == 9)
        {
            firstPlayer = 90;
        }

        int secondPlayer = firstPlayer + 1;
        int thirdPlayer = firstPlayer + 2;
        int fourthPlayer = firstPlayer + 3;
        int fifthPlayer = firstPlayer + 4;
        //Show away teams names
        awayStarter1.text = roster.playerNames[firstPlayer];
        awayStarter2.text = roster.playerNames[secondPlayer];
        awayStarter3.text = roster.playerNames[thirdPlayer];
        awayStarter4.text = roster.playerNames[fourthPlayer];
        awayStarter5.text = roster.playerNames[fifthPlayer];
    }
    //Simulate a match on play press
    public void playMatch()
    {
        //Turn off play button and turn on return button
        playButton.gameObject.SetActive(false);
        scoreBreakdown.gameObject.SetActive(true);
        //Set the name in the score table
        awayScoreName.text = teamNames[gameNumber];
        //Reset the score
        homeScore = 0;
        awayScore = 0;

        //Cycle through each quarter of the match
        for (int quarter = 1; quarter != 5; quarter++)
        {
            //Simulate the quarter, then assign the scores to corresponding space in table
            simQuarter();
            if (quarter == 1)
            {
                homeScore1.text = homeQuarterScore.ToString();
                awayScore1.text = awayQuarterScore.ToString();
            }            
            if (quarter == 2)
            {
                homeScore2.text = homeQuarterScore.ToString();
                awayScore2.text = awayQuarterScore.ToString();
            }           
            if (quarter == 3)
            {
                homeScore3.text = homeQuarterScore.ToString();
                awayScore3.text = awayQuarterScore.ToString();
            }          
            if (quarter == 4)
            {
                homeScore4.text = homeQuarterScore.ToString();
                awayScore4.text = awayQuarterScore.ToString();
            }
            
        }
        //If after 4 quarters the scores are tied, sim again for overtime
        if (homeScore==awayScore)
        {
            simQuarter();
        }
        //Send score to console for testing
        Debug.Log($"Home score = {homeScore} away = {awayScore}");
        //Update score on screen
        scoreText.text = ($"{homeScore} - {awayScore}");
        playButton.gameObject.SetActive(false);
        //Find the winner and update their record and happiness levels
        if (homeScore > awayScore)
        {
            roster.teamWins[0] = roster.teamWins[0] + 1;
            roster.teamLosses[gameNumber] = roster.teamLosses[gameNumber] + 1;
            for (int i = 0; i < 10; i++)
            {
                roster.happiness[i] = roster.happiness[i] + 3;
                if (roster.happiness[i] > 99)
                {
                    roster.happiness[i] = 99;
                }
            }
            //Drop happiness for opponent
            //Game number * 10 will result in that teams first player, + 10 is last player on team
            int teamHappinessDrops = gameNumber * 10;
            int teamHappinessLast = teamHappinessDrops + 10;
            for (int i = teamHappinessDrops; i != teamHappinessLast; i++ )
            {
                //Star players lose more happiness
                if (roster.ovrRtg[i] > 84)
                {
                    roster.happiness[i] = roster.happiness[i] - 5;

                }
                else
                {
                    roster.happiness[i] = roster.happiness[i] - 3;
                }
            }

        }
        if (awayScore > homeScore)
        {
            roster.teamWins[gameNumber]= roster.teamWins[gameNumber] + 1;
            roster.teamLosses[0] = roster.teamLosses[0] + 1;
            for (int i = 0; i <10;i++ )
            {
                //Star players lose more happiness
                if (roster.ovrRtg[i] > 84)
                {
                    roster.happiness[i] = roster.happiness[i] - 5;

                }
                else
                {
                    roster.happiness[i] = roster.happiness[i] - 3;
                }
            }
           
        }
        for (int i = 5; i < 10; i++)
        {
            if (roster.ovrRtg[i] > 76)
            {
                roster.happiness[i] = roster.happiness[i] - 3;
            }
        }
        //Update each teams points tally for standings tie break
        roster.teamPoints[0] = roster.teamPoints[0] + homeScore;
        roster.teamPoints[gameNumber] = roster.teamPoints[gameNumber] + awayScore;
        //Make every other team play their matches
        simOtherMatches();
        returnToHomeButton.gameObject.SetActive(true);
    }
    //Go back to home screen and update details
    public void returnHome()
    {   
        match.SetActive(false);
        home.SetActive(true);
        gameNumber++;
        updateHomeScreen();
        

    }
    //Simulate the quarter of a match
    public void simQuarter()
    {
        //Find the average team stats
        calcMatchStats();
        //Calculate rating comparisons
        homeOutAwayPerim = homeOutsideScoring - awayPerimeterDefence;
        homeInAwayIn = homeInsideScoring - awayInsideDefence;
        awayOutHomePerim = awayOutsideScoring - homePerimeterDefence;
        awayInHomeIn = awayInsideScoring - homeInsideDefence;

        homeOffawayDef = roster.teamOffense[0] - roster.teamDefence[gameNumber];
        homeDefawayOff = roster.teamOffense[gameNumber] - roster.teamDefence[0];
        //Set default max score
        int homeMaxScore = 8;
        int awayMaxScore = 8;
        //Home scoring
        //Outside scoring vs perimeter defence, if statement is met, increase the maximum possible score by set number
        if (homeOutAwayPerim > 5)
        {
            homeMaxScore = homeMaxScore + 21;
        }
        else if (homeOutAwayPerim > 2)
        {
            homeMaxScore = homeMaxScore + 15;
        }
        else if (homeOutAwayPerim >= 0)
        {
            homeMaxScore = homeMaxScore + 12;
        }
        else if (homeOutAwayPerim < -5 )
        {
            homeMaxScore = homeMaxScore + 3;
        }

        else if (homeOutAwayPerim < -2)
        {
            homeMaxScore = homeMaxScore + 6;
        } 
        else if (homeOutAwayPerim < 0)
        {
            homeMaxScore = homeMaxScore + 9;
        }

        //Inside Scoring vs inside defence
        if (homeInAwayIn > 5)
        {
            homeMaxScore = homeMaxScore + 20;
        }
        else if (homeInAwayIn > 2)
        {
            homeMaxScore = homeMaxScore + 14;
        }
        else if (homeInAwayIn >= 0)
        {
            homeMaxScore = homeMaxScore + 10;
        }
        else if (homeInAwayIn < -5)
        {
            homeMaxScore = homeMaxScore + 4;
        }

        else if (homeInAwayIn < -2)
        {
            homeMaxScore = homeMaxScore + 6;
        }
        else if (homeInAwayIn < 0)
        {
            homeMaxScore = homeMaxScore + 8;
        }



        //Away team scoring
        //Outside scoring
        if (awayOutHomePerim > 5)
        {
            awayMaxScore = awayMaxScore + 21;
        }
        else if (awayOutHomePerim > 2)
        {
            awayMaxScore = awayMaxScore + 15;
        }
        else if (awayOutHomePerim >= 0)
        {
            awayMaxScore = awayMaxScore + 12;
        }
        else if (awayOutHomePerim < -5)
        {
            awayMaxScore = awayMaxScore + 3;
        }

        else if (awayOutHomePerim < -2)
        {
            awayMaxScore = awayMaxScore + 6;
        }
        else if (awayOutHomePerim < 0)
        {
            awayMaxScore = awayMaxScore + 9;
        }

        //Inside Scoring
        if (awayInHomeIn > 5)
        {
            awayMaxScore = awayMaxScore + 20;
        }
        else if (awayInHomeIn > 2)
        {
            awayMaxScore = awayMaxScore + 14;
        }
        else if (awayInHomeIn >= 0)
        {
            awayMaxScore = awayMaxScore + 10;
        }
        else if (awayInHomeIn < -5)
        {
            awayMaxScore = awayMaxScore + 4;
        }

        else if (awayInHomeIn < -2)
        {
            awayMaxScore = awayMaxScore + 6;
        }
        else if (awayInHomeIn < 0)
        {
            awayMaxScore = awayMaxScore + 8;
        }

        //Score generation based on above calculations
        homeQuarterScore = rnd.Next(10, homeMaxScore);
        awayQuarterScore = rnd.Next(10, awayMaxScore);
        
        
        
        //Combine quarter scores
        homeScore = homeScore + homeQuarterScore;
        awayScore = awayQuarterScore + awayScore;
    }
    //Simulate other matches across the league by game number. This ensures every team plays eachother once
    public void simOtherMatches()
    {
        if (gameNumber == 1)
        {
            //0v1 2v3 4v5 6v7 8v9
            simHomeTeam = 2;
            simAwayTeam = 3;
            matchSimulation();
            simHomeTeam = 4;
            simAwayTeam = 5;
            matchSimulation();
            simHomeTeam = 6;
            simAwayTeam = 7;
            matchSimulation();
            simHomeTeam = 8;
            simAwayTeam = 9;
            matchSimulation();
        }        
        if (gameNumber == 2)
        {
            //0v2 1v9 3v4 5v6 7v8        
            simHomeTeam = 1;
            simAwayTeam = 9;
            matchSimulation();
            simHomeTeam = 3;
            simAwayTeam = 4;
            matchSimulation();
            simHomeTeam = 5;
            simAwayTeam = 6;
            matchSimulation();
            simHomeTeam = 7;
            simAwayTeam = 8;
            matchSimulation();
        }
        if (gameNumber == 3)
        {
            //0v3 1v8 2v9 4v6 5v7   
            simHomeTeam = 1;
            simAwayTeam = 8;
            matchSimulation();
            simHomeTeam = 2;
            simAwayTeam = 9;
            matchSimulation();
            simHomeTeam = 4;
            simAwayTeam = 6;
            matchSimulation();
            simHomeTeam = 5;
            simAwayTeam = 7;
            matchSimulation();

        }
        if (gameNumber == 4)
        {
            //0v4 1v7 2v8 3v5 6v9   
            simHomeTeam = 1;
            simAwayTeam = 7;
            matchSimulation();
            simHomeTeam = 2;
            simAwayTeam = 8;
            matchSimulation();
            simHomeTeam = 3;
            simAwayTeam = 5;
            matchSimulation();
            simHomeTeam = 6;
            simAwayTeam = 9;
            matchSimulation();
        }
        if (gameNumber == 5)
        {
            //0v5 1v6 2v4 3v7 8v9
            simHomeTeam = 1;
            simAwayTeam = 6;
            matchSimulation();
            simHomeTeam = 2;
            simAwayTeam = 4;
            matchSimulation();
            simHomeTeam = 3;
            simAwayTeam = 7;
            matchSimulation();
            simHomeTeam = 8;
            simAwayTeam = 9;
            matchSimulation();
        }
        if (gameNumber == 6)
        {
            //0v6 1v5 2v7 3v8 4v9
            simHomeTeam = 1;
            simAwayTeam = 5;
            matchSimulation();
            simHomeTeam = 2;
            simAwayTeam = 7;
            matchSimulation();
            simHomeTeam = 3;
            simAwayTeam = 8;
            matchSimulation();
            simHomeTeam = 4;
            simAwayTeam = 9;
            matchSimulation();
        }
        if (gameNumber == 7)
        {
            //0v7 1v4 2v5 3v9 6v8
            simHomeTeam = 1;
            simAwayTeam = 4;
            matchSimulation();
            simHomeTeam = 2;
            simAwayTeam = 5;
            matchSimulation();
            simHomeTeam = 3;
            simAwayTeam = 9;
            matchSimulation();
            simHomeTeam = 6;
            simAwayTeam = 8;
            matchSimulation();
        }
        if (gameNumber == 8)
        {
            //0v8 1v3 2v6 4v7 5v9
            simHomeTeam = 1;
            simAwayTeam = 3;
            matchSimulation();
            simHomeTeam = 2;
            simAwayTeam = 6;
            matchSimulation();
            simHomeTeam = 4;
            simAwayTeam = 7;
            matchSimulation();
            simHomeTeam = 5;
            simAwayTeam = 9;
            matchSimulation();
        }
        if (gameNumber == 9)
        {
            //0v9 1v2 3v6  4v8 5v7
            simHomeTeam = 1;
            simAwayTeam = 2;
            matchSimulation();
            simHomeTeam = 3;
            simAwayTeam = 6;
            matchSimulation();
            simHomeTeam = 4;
            simAwayTeam = 8;
            matchSimulation();
            simHomeTeam = 5;
            simAwayTeam = 7;
            matchSimulation();
        }

    }


    //A simplified match engine for non-user matches
    public void matchSimulation()
    {
        //If home team is stronger, they have better chance of winning by higher range.
        if (roster.teamOvr[simHomeTeam] > roster.teamOvr[simAwayTeam])
        {
            simHomePoints = rnd.Next(70, 130);
            simAwayPoints = rnd.Next(60, 120);
        
        }
        //If away team is stronger, they have better chance of winning by higher range.

        else if (roster.teamOvr[simAwayTeam] > roster.teamOvr[simHomeTeam])
        {
            simHomePoints = rnd.Next(60, 120);
            simAwayPoints = rnd.Next(70, 130);
        }
        //If tied rating, equal score ranges.

        else
        {
            simHomePoints = rnd.Next(60, 120);
            simAwayPoints = rnd.Next(60, 120);
        }
        //Find the winner and update records
        if (simHomePoints > simAwayPoints)
        {
            roster.teamWins[simHomeTeam] = roster.teamWins[simHomeTeam] + 1;
            roster.teamLosses[simAwayTeam] = roster.teamLosses[simAwayTeam] + 1;
            //Update losing team happiness
            int simHappinessDrops = simAwayTeam * 10;
            int simHappinessLast = simHappinessDrops + 10;
            for (int i = simHappinessDrops; i != simHappinessLast; i++)
            {
                //Star players lose more happiness
                if (roster.ovrRtg[i] > 84)
                {
                    roster.happiness[i] = roster.happiness[i] - 5;

                }
                else
                {
                    roster.happiness[i] = roster.happiness[i] - 3;
                }
            }


        }
        else if (simAwayPoints >= simHomePoints)
        {
            roster.teamWins[simAwayTeam] = roster.teamWins[simAwayTeam] + 1;
            roster.teamLosses[simHomeTeam] = roster.teamLosses[simHomeTeam] + 1;
            //Update losers happiness
            int simHappinessDrops = simHomeTeam * 10;
            int simHappinessLast = simHappinessDrops + 10;
            for (int i = simHappinessDrops; i != simHappinessLast; i++)
            {
                //Star players lose more happiness
                if (roster.ovrRtg[i] > 84)
                {
                    roster.happiness[i] = roster.happiness[i] - 5;

                }
                else
                {
                    roster.happiness[i] = roster.happiness[i] - 3;
                }
            }

        }
        roster.teamPoints[simHomeTeam] = roster.teamPoints[simHomeTeam] + simHomePoints;
        roster.teamPoints[simAwayTeam] = roster.teamPoints[simAwayTeam] + simAwayPoints;
        simHomePoints = 0;
        simAwayPoints = 0;
        
    }
    //Calculate the user teams best player
    public void homeKeyPlayerCalc()
    {
        //Start at 0
        int keyPlayer = 0;
        homeKeyPlayerRating = 0;
        //Check each player and update with the highest rated
        for (int i = 0; i != 10; i++)
        {
            if (roster.ovrRtg[i] >= homeKeyPlayerRating)
            {
                homeKeyPlayerRating = roster.ovrRtg[i];
                keyPlayer = i;
            }

        }
        homeKeyPlayer.text = roster.playerNames[keyPlayer];
        homeKPRating.text = homeKeyPlayerRating.ToString();
    }

    //Find each teams average ratings
    public void calcMatchStats()
    {
        //Home Team Calculation with weighted averages towards starting lineup
        //Default values
        int playerCounter = 0;
        int lastPlayer = 10;
        int combinedOutsideScoring = 0;
        int combinedInsideScoring = 0;
        int combinedPerimeterDefence = 0;
        int combinedInsideDefence = 0;
        for (playerCounter =0; playerCounter!= lastPlayer;playerCounter++)
        {
            //After the starting 5, ratings are doubled as these players play more
            if (playerCounter == 5)
            {
                combinedInsideDefence = combinedInsideDefence * 2;
                combinedInsideScoring = combinedInsideScoring * 2;
                combinedOutsideScoring = combinedOutsideScoring * 2;
                combinedPerimeterDefence = combinedPerimeterDefence * 2;
            }
            //Add to combined tally
            combinedInsideDefence = combinedInsideDefence + roster.insideDefRtg[playerCounter];
            combinedPerimeterDefence = combinedPerimeterDefence + roster.perimeterDefRtg[playerCounter];
            combinedInsideScoring = combinedInsideScoring + roster.insideScoringRtg[playerCounter];
            combinedOutsideScoring = combinedOutsideScoring + roster.outsideScoringRtg[playerCounter];


        }
        //Find average
        homeInsideScoring = combinedInsideScoring / 15;
        homeInsideDefence = combinedInsideDefence / 15;
        homePerimeterDefence = combinedPerimeterDefence / 15;
        homeOutsideScoring = combinedOutsideScoring / 15;

        //Away team, not weighted as team lineups arent edited
        playerCounter = gameNumber * 10;
        lastPlayer = playerCounter + 10;

        combinedOutsideScoring = 0;
        combinedInsideScoring = 0;
        combinedPerimeterDefence = 0;
        combinedInsideDefence = 0;

        for (playerCounter = gameNumber*10; playerCounter != lastPlayer; playerCounter++)
        {
            combinedInsideDefence = combinedInsideDefence + roster.insideDefRtg[playerCounter];
            combinedPerimeterDefence = combinedPerimeterDefence + roster.perimeterDefRtg[playerCounter];
            combinedInsideScoring = combinedInsideScoring + roster.insideScoringRtg[playerCounter];
            combinedOutsideScoring = combinedOutsideScoring + roster.outsideScoringRtg[playerCounter];

        }

        awayInsideScoring = combinedInsideScoring / 10;
        awayInsideDefence = combinedInsideDefence / 10;
        awayPerimeterDefence = combinedPerimeterDefence / 10;
        awayOutsideScoring = combinedOutsideScoring / 10;
    }

    //Find the league winner at the end of the season and offer replay or return to menu
    public void endOfSeason()
    {
        //Run a final standings check
        roster.standingsCalc();
        //Assign the winner
        leagueWinner = roster.standingsNameText1.text;
        //Check if user has won
        if (leagueWinner == "London")
        {            
            home.SetActive(false);
            winnerScreen.SetActive(true);
        }
        else
        {            
            home.SetActive(false);
            loserScreen.SetActive(true);
            winningTeamName.text = $"{leagueWinner} \n European Champions 2021"; ;
        }
    }
}
