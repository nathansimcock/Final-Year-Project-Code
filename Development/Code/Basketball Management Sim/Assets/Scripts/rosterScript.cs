using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class rosterScript : MonoBehaviour
{
    //Variables for creating the roster
    public List<string> playerNames = new List<string>();
    public List<string> firstNames = new List<string>();
    public List<string> surnames = new List<string>();
    public List<int> insideScoringRtg = new List<int>();
    public List<int> outsideScoringRtg = new List<int>();
    public List<int> playmakingRtg = new List<int>();
    public List<int> ballHandlingRtg = new List<int>();
    public List<int> insideDefRtg = new List<int>();
    public List<int> perimeterDefRtg = new List<int>();
    public List<int> ovrRtg = new List<int>();
    public List<string> teamName = new List<string>();
    public List<int> happiness = new List<int>();
    public List<int> tradeValue = new List<int>();
    

    //Team stats
    public List<int> teamOffense = new List<int>();
    public List<int> teamDefence = new List<int>();
    public List<int> teamInScoring = new List<int>();
    public List<int> teamOutScoring = new List<int>();
    public List<int> teamInDefence = new List<int>();
    public List<int> teamPerimDefence = new List<int>();
    public List<int> teamOvr = new List<int>();

    //Team Records
    public List<int> teamWins = new List<int>();
    public List<int> teamLosses = new List<int>();
    public List<int> teamPoints = new List<int>();
    
    //Number generator
    System.Random rnd = new System.Random();

    //Variables for displaying the roster

    //Names
    public TMPro.TextMeshProUGUI playerName1;
    public TMPro.TextMeshProUGUI playerName2;
    public TMPro.TextMeshProUGUI playerName3;
    public TMPro.TextMeshProUGUI playerName4;
    public TMPro.TextMeshProUGUI playerName5;
    public TMPro.TextMeshProUGUI playerName6;
    public TMPro.TextMeshProUGUI playerName7;
    public TMPro.TextMeshProUGUI playerName8;
    public TMPro.TextMeshProUGUI playerName9;
    public TMPro.TextMeshProUGUI playerName10;    
    
    public TMPro.TextMeshProUGUI tradePlayerName1;
    public TMPro.TextMeshProUGUI tradePlayerName2;
    public TMPro.TextMeshProUGUI tradePlayerName3;
    public TMPro.TextMeshProUGUI tradePlayerName4;
    public TMPro.TextMeshProUGUI tradePlayerName5;
    public TMPro.TextMeshProUGUI tradePlayerName6;
    public TMPro.TextMeshProUGUI tradePlayerName7;
    public TMPro.TextMeshProUGUI tradePlayerName8;
    public TMPro.TextMeshProUGUI tradePlayerName9;
    public TMPro.TextMeshProUGUI tradePlayerName10;

    //Ratings
    //Inside Scoring
    public TMPro.TextMeshProUGUI insideScoring1;
    public TMPro.TextMeshProUGUI insideScoring2;
    public TMPro.TextMeshProUGUI insideScoring3;
    public TMPro.TextMeshProUGUI insideScoring4;
    public TMPro.TextMeshProUGUI insideScoring5;
    public TMPro.TextMeshProUGUI insideScoring6;
    public TMPro.TextMeshProUGUI insideScoring7;
    public TMPro.TextMeshProUGUI insideScoring8;
    public TMPro.TextMeshProUGUI insideScoring9;
    public TMPro.TextMeshProUGUI insideScoring10;
    //Oustide Scoring
    public TMPro.TextMeshProUGUI outsideScoring1;
    public TMPro.TextMeshProUGUI outsideScoring2;
    public TMPro.TextMeshProUGUI outsideScoring3;
    public TMPro.TextMeshProUGUI outsideScoring4;
    public TMPro.TextMeshProUGUI outsideScoring5;
    public TMPro.TextMeshProUGUI outsideScoring6;
    public TMPro.TextMeshProUGUI outsideScoring7;
    public TMPro.TextMeshProUGUI outsideScoring8;
    public TMPro.TextMeshProUGUI outsideScoring9;
    public TMPro.TextMeshProUGUI outsideScoring10;    
    //Ball handling
    public TMPro.TextMeshProUGUI ballHandling1;
    public TMPro.TextMeshProUGUI ballHandling2;
    public TMPro.TextMeshProUGUI ballHandling3;
    public TMPro.TextMeshProUGUI ballHandling4;
    public TMPro.TextMeshProUGUI ballHandling5;
    public TMPro.TextMeshProUGUI ballHandling6;
    public TMPro.TextMeshProUGUI ballHandling7;
    public TMPro.TextMeshProUGUI ballHandling8;
    public TMPro.TextMeshProUGUI ballHandling9;
    public TMPro.TextMeshProUGUI ballHandling10;   
    //Playmaking
    public TMPro.TextMeshProUGUI playmaking1;
    public TMPro.TextMeshProUGUI playmaking2;
    public TMPro.TextMeshProUGUI playmaking3;
    public TMPro.TextMeshProUGUI playmaking4;
    public TMPro.TextMeshProUGUI playmaking5;
    public TMPro.TextMeshProUGUI playmaking6;
    public TMPro.TextMeshProUGUI playmaking7;
    public TMPro.TextMeshProUGUI playmaking8;
    public TMPro.TextMeshProUGUI playmaking9;
    public TMPro.TextMeshProUGUI playmaking10;    
    //Inside Defence
    public TMPro.TextMeshProUGUI insideDefence1;
    public TMPro.TextMeshProUGUI insideDefence2;
    public TMPro.TextMeshProUGUI insideDefence3;
    public TMPro.TextMeshProUGUI insideDefence4;
    public TMPro.TextMeshProUGUI insideDefence5;
    public TMPro.TextMeshProUGUI insideDefence6;
    public TMPro.TextMeshProUGUI insideDefence7;
    public TMPro.TextMeshProUGUI insideDefence8;
    public TMPro.TextMeshProUGUI insideDefence9;
    public TMPro.TextMeshProUGUI insideDefence10;    
    //Perimeter Defence
    public TMPro.TextMeshProUGUI perimeterDefence1;
    public TMPro.TextMeshProUGUI perimeterDefence2;
    public TMPro.TextMeshProUGUI perimeterDefence3;
    public TMPro.TextMeshProUGUI perimeterDefence4;
    public TMPro.TextMeshProUGUI perimeterDefence5;
    public TMPro.TextMeshProUGUI perimeterDefence6;
    public TMPro.TextMeshProUGUI perimeterDefence7;
    public TMPro.TextMeshProUGUI perimeterDefence8;
    public TMPro.TextMeshProUGUI perimeterDefence9;
    public TMPro.TextMeshProUGUI perimeterDefence10;    
    //Perimeter Defence
    public TMPro.TextMeshProUGUI overall1;
    public TMPro.TextMeshProUGUI overall2;
    public TMPro.TextMeshProUGUI overall3;
    public TMPro.TextMeshProUGUI overall4;
    public TMPro.TextMeshProUGUI overall5;
    public TMPro.TextMeshProUGUI overall6;
    public TMPro.TextMeshProUGUI overall7;
    public TMPro.TextMeshProUGUI overall8;
    public TMPro.TextMeshProUGUI overall9;
    public TMPro.TextMeshProUGUI overall10;    
    //Trade ratings
    public TMPro.TextMeshProUGUI tradeOverall1;
    public TMPro.TextMeshProUGUI tradeOverall2;
    public TMPro.TextMeshProUGUI tradeOverall3;
    public TMPro.TextMeshProUGUI tradeOverall4;
    public TMPro.TextMeshProUGUI tradeOverall5;
    public TMPro.TextMeshProUGUI tradeOverall6;
    public TMPro.TextMeshProUGUI tradeOverall7;
    public TMPro.TextMeshProUGUI tradeOverall8;
    public TMPro.TextMeshProUGUI tradeOverall9;
    public TMPro.TextMeshProUGUI tradeOverall10;

    //Player happiness
    public TMPro.TextMeshProUGUI happiness1;
    public TMPro.TextMeshProUGUI happiness2;
    public TMPro.TextMeshProUGUI happiness3;
    public TMPro.TextMeshProUGUI happiness4;
    public TMPro.TextMeshProUGUI happiness5;
    public TMPro.TextMeshProUGUI happiness6;
    public TMPro.TextMeshProUGUI happiness7;
    public TMPro.TextMeshProUGUI happiness8;
    public TMPro.TextMeshProUGUI happiness9;
    public TMPro.TextMeshProUGUI happiness10;
    //Stars used for trade value
    public Image baseStar1;
    public Image baseStar2;
    public Image baseStar3;
    public Image baseStar4;
    public Image baseStar5;    
    
    public Image tradeStar1;
    public Image tradeStar2;
    public Image tradeStar3;
    public Image tradeStar4;
    public Image tradeStar5;    
    public Image tradeStar6;
    public Image tradeStar7;
    public Image tradeStar8;
    public Image tradeStar9;
    public Image tradeStar10;

    public Sprite oneStar;
    public Sprite twoStar;
    public Sprite threeStar;
    public Sprite fourStar;
    public Sprite fiveStar;
    //Trade details
    public TMPro.TextMeshProUGUI tradeTeamName;
    public TMPro.TextMeshProUGUI tradeOfferName;
    public TMPro.TextMeshProUGUI tradeOfferOvr;
    public TMPro.TextMeshProUGUI tradeReceiveName;
    public TMPro.TextMeshProUGUI tradeReceiveOvr;    
    public TMPro.TextMeshProUGUI tradeNumberText;

    //Trade buttons
    public Button tradePlayer1;
    public Button tradePlayer2;
    public Button tradePlayer3;
    public Button tradePlayer4;
    public Button tradePlayer5;
    public Button tradePlayer6;
    public Button tradePlayer7;
    public Button tradePlayer8;
    public Button tradePlayer9;
    public Button tradePlayer10;

    public Button goToNextTrade;
    public Button goToPrevTrade;
    bool goingForward;
    public Button tradeButton;
    //Trade info
    int tradeNumber;
    int playerTraded;
    int tradeCount;
    int totalTrades;
    //Team records to be displayed
    public TMPro.TextMeshProUGUI teamWins1;
    public TMPro.TextMeshProUGUI teamWins2;
    public TMPro.TextMeshProUGUI teamWins3;
    public TMPro.TextMeshProUGUI teamWins4;
    public TMPro.TextMeshProUGUI teamWins5;
    public TMPro.TextMeshProUGUI teamWins6;
    public TMPro.TextMeshProUGUI teamWins7;
    public TMPro.TextMeshProUGUI teamWins8;
    public TMPro.TextMeshProUGUI teamWins9;
    public TMPro.TextMeshProUGUI teamWins10;  
    
    public TMPro.TextMeshProUGUI teamlosses1;
    public TMPro.TextMeshProUGUI teamlosses2;
    public TMPro.TextMeshProUGUI teamlosses3;
    public TMPro.TextMeshProUGUI teamlosses4;
    public TMPro.TextMeshProUGUI teamlosses5;
    public TMPro.TextMeshProUGUI teamlosses6;
    public TMPro.TextMeshProUGUI teamlosses7;
    public TMPro.TextMeshProUGUI teamlosses8;
    public TMPro.TextMeshProUGUI teamlosses9;
    public TMPro.TextMeshProUGUI teamlosses10;       
    
    public TMPro.TextMeshProUGUI teamPoints1;
    public TMPro.TextMeshProUGUI teamPoints2;
    public TMPro.TextMeshProUGUI teamPoints3;
    public TMPro.TextMeshProUGUI teamPoints4;
    public TMPro.TextMeshProUGUI teamPoints5;
    public TMPro.TextMeshProUGUI teamPoints6;
    public TMPro.TextMeshProUGUI teamPoints7;
    public TMPro.TextMeshProUGUI teamPoints8;
    public TMPro.TextMeshProUGUI teamPoints9;
    public TMPro.TextMeshProUGUI teamPoints10;    
    

    public TMPro.TextMeshProUGUI gamesBehind7;
    public TMPro.TextMeshProUGUI gamesBehind8;
    public TMPro.TextMeshProUGUI gamesBehind9;
    public TMPro.TextMeshProUGUI gamesBehind10;

    public TMPro.TextMeshProUGUI standingsNameText1;
    public TMPro.TextMeshProUGUI standingsNameText2;
    public TMPro.TextMeshProUGUI standingsNameText3;
    public TMPro.TextMeshProUGUI standingsNameText4;
    public TMPro.TextMeshProUGUI standingsNameText5;
    public TMPro.TextMeshProUGUI standingsNameText6;
    public TMPro.TextMeshProUGUI standingsNameText7;
    public TMPro.TextMeshProUGUI standingsNameText8;
    public TMPro.TextMeshProUGUI standingsNameText9;
    public TMPro.TextMeshProUGUI standingsNameText10;    
    //Team stats to be displayed
    public TMPro.TextMeshProUGUI OffRtgText1;
    public TMPro.TextMeshProUGUI OffRtgText2;
    public TMPro.TextMeshProUGUI OffRtgText3;
    public TMPro.TextMeshProUGUI OffRtgText4;
    public TMPro.TextMeshProUGUI OffRtgText5;
    public TMPro.TextMeshProUGUI OffRtgText6;
    public TMPro.TextMeshProUGUI OffRtgText7;
    public TMPro.TextMeshProUGUI OffRtgText8;
    public TMPro.TextMeshProUGUI OffRtgText9;
    public TMPro.TextMeshProUGUI OffRtgText10;   
    
    public TMPro.TextMeshProUGUI DefRtgText1;
    public TMPro.TextMeshProUGUI DefRtgText2;
    public TMPro.TextMeshProUGUI DefRtgText3;
    public TMPro.TextMeshProUGUI DefRtgText4;
    public TMPro.TextMeshProUGUI DefRtgText5;
    public TMPro.TextMeshProUGUI DefRtgText6;
    public TMPro.TextMeshProUGUI DefRtgText7;
    public TMPro.TextMeshProUGUI DefRtgText8;
    public TMPro.TextMeshProUGUI DefRtgText9;
    public TMPro.TextMeshProUGUI DefRtgText10;    

    public TMPro.TextMeshProUGUI OvrRtgText1;
    public TMPro.TextMeshProUGUI OvrRtgText2;
    public TMPro.TextMeshProUGUI OvrRtgText3;
    public TMPro.TextMeshProUGUI OvrRtgText4;
    public TMPro.TextMeshProUGUI OvrRtgText5;
    public TMPro.TextMeshProUGUI OvrRtgText6;
    public TMPro.TextMeshProUGUI OvrRtgText7;
    public TMPro.TextMeshProUGUI OvrRtgText8;
    public TMPro.TextMeshProUGUI OvrRtgText9;
    public TMPro.TextMeshProUGUI OvrRtgText10;

    public TMPro.TextMeshProUGUI teamInscoringText1;
    public TMPro.TextMeshProUGUI teamInscoringText2;
    public TMPro.TextMeshProUGUI teamInscoringText3;
    public TMPro.TextMeshProUGUI teamInscoringText4;
    public TMPro.TextMeshProUGUI teamInscoringText5;
    public TMPro.TextMeshProUGUI teamInscoringText6;
    public TMPro.TextMeshProUGUI teamInscoringText7;
    public TMPro.TextMeshProUGUI teamInscoringText8;
    public TMPro.TextMeshProUGUI teamInscoringText9;
    public TMPro.TextMeshProUGUI teamInscoringText10;

    public TMPro.TextMeshProUGUI teamOutscoringText1;
    public TMPro.TextMeshProUGUI teamOutscoringText2;
    public TMPro.TextMeshProUGUI teamOutscoringText3;
    public TMPro.TextMeshProUGUI teamOutscoringText4;
    public TMPro.TextMeshProUGUI teamOutscoringText5;
    public TMPro.TextMeshProUGUI teamOutscoringText6;
    public TMPro.TextMeshProUGUI teamOutscoringText7;
    public TMPro.TextMeshProUGUI teamOutscoringText8;
    public TMPro.TextMeshProUGUI teamOutscoringText9;
    public TMPro.TextMeshProUGUI teamOutscoringText10;

    public TMPro.TextMeshProUGUI teamInDefenceText1;
    public TMPro.TextMeshProUGUI teamInDefenceText2;
    public TMPro.TextMeshProUGUI teamInDefenceText3;
    public TMPro.TextMeshProUGUI teamInDefenceText4;
    public TMPro.TextMeshProUGUI teamInDefenceText5;
    public TMPro.TextMeshProUGUI teamInDefenceText6;
    public TMPro.TextMeshProUGUI teamInDefenceText7;
    public TMPro.TextMeshProUGUI teamInDefenceText8;
    public TMPro.TextMeshProUGUI teamInDefenceText9;
    public TMPro.TextMeshProUGUI teamInDefenceText10;

    public TMPro.TextMeshProUGUI teamPerimeterDefenceText1;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText2;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText3;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText4;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText5;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText6;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText7;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText8;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText9;
    public TMPro.TextMeshProUGUI teamPerimeterDefenceText10;
    //Player happiness issues
    public TMPro.TextMeshProUGUI playerIssue1;
    public TMPro.TextMeshProUGUI playerIssue2;
    public TMPro.TextMeshProUGUI playerIssue3;

    //Ratings for lineup editor
    //Inside Scoring
    public TMPro.TextMeshProUGUI lineUpinsideScoring1;
    public TMPro.TextMeshProUGUI lineUpinsideScoring2;
    public TMPro.TextMeshProUGUI lineUpinsideScoring3;
    public TMPro.TextMeshProUGUI lineUpinsideScoring4;
    public TMPro.TextMeshProUGUI lineUpinsideScoring5;
    public TMPro.TextMeshProUGUI lineUpinsideScoring6;
    public TMPro.TextMeshProUGUI lineUpinsideScoring7;
    public TMPro.TextMeshProUGUI lineUpinsideScoring8;
    public TMPro.TextMeshProUGUI lineUpinsideScoring9;
    public TMPro.TextMeshProUGUI lineUpinsideScoring10;
    //Oustide Scoring
    public TMPro.TextMeshProUGUI lineUpoutsideScoring1;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring2;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring3;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring4;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring5;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring6;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring7;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring8;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring9;
    public TMPro.TextMeshProUGUI lineUpoutsideScoring10;
    //Ball handling
    public TMPro.TextMeshProUGUI lineUpballHandling1;
    public TMPro.TextMeshProUGUI lineUpballHandling2;
    public TMPro.TextMeshProUGUI lineUpballHandling3;
    public TMPro.TextMeshProUGUI lineUpballHandling4;
    public TMPro.TextMeshProUGUI lineUpballHandling5;
    public TMPro.TextMeshProUGUI lineUpballHandling6;
    public TMPro.TextMeshProUGUI lineUpballHandling7;
    public TMPro.TextMeshProUGUI lineUpballHandling8;
    public TMPro.TextMeshProUGUI lineUpballHandling9;
    public TMPro.TextMeshProUGUI lineUpballHandling10;
    //Playmaking
    public TMPro.TextMeshProUGUI lineUpplaymaking1;
    public TMPro.TextMeshProUGUI lineUpplaymaking2;
    public TMPro.TextMeshProUGUI lineUpplaymaking3;
    public TMPro.TextMeshProUGUI lineUpplaymaking4;
    public TMPro.TextMeshProUGUI lineUpplaymaking5;
    public TMPro.TextMeshProUGUI lineUpplaymaking6;
    public TMPro.TextMeshProUGUI lineUpplaymaking7;
    public TMPro.TextMeshProUGUI lineUpplaymaking8;
    public TMPro.TextMeshProUGUI lineUpplaymaking9;
    public TMPro.TextMeshProUGUI lineUpplaymaking10;
    //Inside Defence
    public TMPro.TextMeshProUGUI lineUpinsideDefence1;
    public TMPro.TextMeshProUGUI lineUpinsideDefence2;
    public TMPro.TextMeshProUGUI lineUpinsideDefence3;
    public TMPro.TextMeshProUGUI lineUpinsideDefence4;
    public TMPro.TextMeshProUGUI lineUpinsideDefence5;
    public TMPro.TextMeshProUGUI lineUpinsideDefence6;
    public TMPro.TextMeshProUGUI lineUpinsideDefence7;
    public TMPro.TextMeshProUGUI lineUpinsideDefence8;
    public TMPro.TextMeshProUGUI lineUpinsideDefence9;
    public TMPro.TextMeshProUGUI lineUpinsideDefence10;
    //Perimeter Defence
    public TMPro.TextMeshProUGUI lineUpperimeterDefence1;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence2;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence3;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence4;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence5;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence6;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence7;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence8;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence9;
    public TMPro.TextMeshProUGUI lineUpperimeterDefence10;
    //Perimeter Defence
    public TMPro.TextMeshProUGUI lineUpoverall1;
    public TMPro.TextMeshProUGUI lineUpoverall2;
    public TMPro.TextMeshProUGUI lineUpoverall3;
    public TMPro.TextMeshProUGUI lineUpoverall4;
    public TMPro.TextMeshProUGUI lineUpoverall5;
    public TMPro.TextMeshProUGUI lineUpoverall6;
    public TMPro.TextMeshProUGUI lineUpoverall7;
    public TMPro.TextMeshProUGUI lineUpoverall8;
    public TMPro.TextMeshProUGUI lineUpoverall9;
    public TMPro.TextMeshProUGUI lineUpoverall10;
    //Player name
    public TMPro.TextMeshProUGUI lineUpplayerName1;
    public TMPro.TextMeshProUGUI lineUpplayerName2;
    public TMPro.TextMeshProUGUI lineUpplayerName3;
    public TMPro.TextMeshProUGUI lineUpplayerName4;
    public TMPro.TextMeshProUGUI lineUpplayerName5;
    public TMPro.TextMeshProUGUI lineUpplayerName6;
    public TMPro.TextMeshProUGUI lineUpplayerName7;
    public TMPro.TextMeshProUGUI lineUpplayerName8;
    public TMPro.TextMeshProUGUI lineUpplayerName9;
    public TMPro.TextMeshProUGUI lineUpplayerName10;
    //Buttons to swap places
    public Button lineUpSwapPlayer1;
    public Button lineUpSwapPlayer2;
    public Button lineUpSwapPlayer3;
    public Button lineUpSwapPlayer4;
    public Button lineUpSwapPlayer5;
    public Button lineUpSwapPlayer6;
    public Button lineUpSwapPlayer7;
    public Button lineUpSwapPlayer8;
    public Button lineUpSwapPlayer9;
    public Button lineUpSwapPlayer10;
    //Whether swap is ready
    bool lineupSwapIn;
    bool lineupSwapOut;
    //Whether its the first run of the system
    bool firstRun;
    //How many wins team 6 has, for games behind calculation
    int teamSixWins;
    //A time limit for updating features
    float updateTime;
    //A timer
    float time;
    //Which player has an issue
    int issue1;
    int issue2;
    int issue3;
    //Player swapped in and out of lineup
    int lineupIn;
    int lineupOut;

    // Start is called before the first frame update
    void Start()
    {
        //Create roster and calculate  player ratings
        createRoster();
        ratingCalculate();
        //Assign objects to their placeholders
        playerName1 = playerName1.GetComponent<TMPro.TextMeshProUGUI>();
        playerName2 = playerName2.GetComponent<TMPro.TextMeshProUGUI>();
        playerName3 = playerName3.GetComponent<TMPro.TextMeshProUGUI>();
        playerName4 = playerName4.GetComponent<TMPro.TextMeshProUGUI>();
        playerName5 = playerName5.GetComponent<TMPro.TextMeshProUGUI>();
        playerName6 = playerName6.GetComponent<TMPro.TextMeshProUGUI>();
        playerName7 = playerName7.GetComponent<TMPro.TextMeshProUGUI>();
        playerName8 = playerName8.GetComponent<TMPro.TextMeshProUGUI>();
        playerName9 = playerName9.GetComponent<TMPro.TextMeshProUGUI>();
        playerName10 = playerName10.GetComponent<TMPro.TextMeshProUGUI>();

       tradePlayerName1 = tradePlayerName1.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName2 = tradePlayerName2.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName3 = tradePlayerName3.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName4 = tradePlayerName4.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName5 = tradePlayerName5.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName6 = tradePlayerName6.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName7 = tradePlayerName7.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName8 = tradePlayerName8.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName9 = tradePlayerName9.GetComponent<TMPro.TextMeshProUGUI>();
       tradePlayerName10 =tradePlayerName10.GetComponent<TMPro.TextMeshProUGUI>();

        insideScoring1  = insideScoring1.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring2  = insideScoring2.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring3  = insideScoring3.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring4  = insideScoring4.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring5  = insideScoring5.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring6  = insideScoring6.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring7  = insideScoring7.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring8  = insideScoring8.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring9  = insideScoring9.GetComponent<TMPro.TextMeshProUGUI>();
        insideScoring10 = insideScoring10.GetComponent<TMPro.TextMeshProUGUI>();

        outsideScoring1 = outsideScoring1.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring2 = outsideScoring2.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring3 = outsideScoring3.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring4 = outsideScoring4.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring5 = outsideScoring5.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring6 = outsideScoring6.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring7 = outsideScoring7.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring8 = outsideScoring8.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring9 = outsideScoring9.GetComponent<TMPro.TextMeshProUGUI>();
        outsideScoring10 = outsideScoring10.GetComponent<TMPro.TextMeshProUGUI>();
                
       ballHandling1 = ballHandling1.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling2 = ballHandling2.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling3 = ballHandling3.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling4 = ballHandling4.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling5 = ballHandling5.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling6 = ballHandling6.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling7 = ballHandling7.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling8 = ballHandling8.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling9 = ballHandling9.GetComponent<TMPro.TextMeshProUGUI>();
       ballHandling10 = ballHandling10.GetComponent<TMPro.TextMeshProUGUI>();      
       
       playmaking1 = playmaking1.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking2 = playmaking2.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking3 = playmaking3.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking4 = playmaking4.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking5 = playmaking5.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking6 = playmaking6.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking7 = playmaking7.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking8 = playmaking8.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking9 = playmaking9.GetComponent<TMPro.TextMeshProUGUI>();
       playmaking10 =playmaking10.GetComponent<TMPro.TextMeshProUGUI>();       
        
       insideDefence1 = insideDefence1.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence2 = insideDefence2.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence3 = insideDefence3.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence4 = insideDefence4.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence5 = insideDefence5.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence6 = insideDefence6.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence7 = insideDefence7.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence8 = insideDefence8.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence9 = insideDefence9.GetComponent<TMPro.TextMeshProUGUI>();
       insideDefence10 =insideDefence10.GetComponent<TMPro.TextMeshProUGUI>();       
        
       perimeterDefence1 = perimeterDefence1.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence2 = perimeterDefence2.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence3 = perimeterDefence3.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence4 = perimeterDefence4.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence5 = perimeterDefence5.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence6 = perimeterDefence6.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence7 = perimeterDefence7.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence8 = perimeterDefence8.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence9 = perimeterDefence9.GetComponent<TMPro.TextMeshProUGUI>();
       perimeterDefence10= perimeterDefence10.GetComponent<TMPro.TextMeshProUGUI>();       
        
       overall1 = overall1.GetComponent<TMPro.TextMeshProUGUI>();
       overall2 = overall2.GetComponent<TMPro.TextMeshProUGUI>();
       overall3 = overall3.GetComponent<TMPro.TextMeshProUGUI>();
       overall4 = overall4.GetComponent<TMPro.TextMeshProUGUI>();
       overall5 = overall5.GetComponent<TMPro.TextMeshProUGUI>();
       overall6 = overall6.GetComponent<TMPro.TextMeshProUGUI>();
       overall7 = overall7.GetComponent<TMPro.TextMeshProUGUI>();
       overall8 = overall8.GetComponent<TMPro.TextMeshProUGUI>();
       overall9 = overall9.GetComponent<TMPro.TextMeshProUGUI>();
       overall10= overall10.GetComponent<TMPro.TextMeshProUGUI>();       
        
       tradeOverall1 = tradeOverall1.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall2 = tradeOverall2.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall3 = tradeOverall3.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall4 = tradeOverall4.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall5 = tradeOverall5.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall6 = tradeOverall6.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall7 = tradeOverall7.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall8 = tradeOverall8.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall9 = tradeOverall9.GetComponent<TMPro.TextMeshProUGUI>();
       tradeOverall10= tradeOverall10.GetComponent<TMPro.TextMeshProUGUI>();       
        
       happiness1 = happiness1.GetComponent<TMPro.TextMeshProUGUI>();
       happiness2 = happiness2.GetComponent<TMPro.TextMeshProUGUI>();
       happiness3 = happiness3.GetComponent<TMPro.TextMeshProUGUI>();
       happiness4 = happiness4.GetComponent<TMPro.TextMeshProUGUI>();
       happiness5 = happiness5.GetComponent<TMPro.TextMeshProUGUI>();
       happiness6 = happiness6.GetComponent<TMPro.TextMeshProUGUI>();
       happiness7 = happiness7.GetComponent<TMPro.TextMeshProUGUI>();
       happiness8 = happiness8.GetComponent<TMPro.TextMeshProUGUI>();
       happiness9 = happiness9.GetComponent<TMPro.TextMeshProUGUI>();
       happiness10= happiness10.GetComponent<TMPro.TextMeshProUGUI>();


        teamWins1 = teamWins1.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins2 = teamWins2.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins3 = teamWins3.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins4 = teamWins4.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins5 = teamWins5.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins6 = teamWins6.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins7 = teamWins7.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins8 = teamWins8.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins9 = teamWins9.GetComponent<TMPro.TextMeshProUGUI>();
        teamWins10 = teamWins10.GetComponent<TMPro.TextMeshProUGUI>();

        teamlosses1 = teamlosses1.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses2 = teamlosses2.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses3 = teamlosses3.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses4 = teamlosses4.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses5 = teamlosses5.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses6 = teamlosses6.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses7 = teamlosses7.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses8 = teamlosses8.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses9 = teamlosses9.GetComponent<TMPro.TextMeshProUGUI>();
        teamlosses10 = teamlosses10.GetComponent<TMPro.TextMeshProUGUI>();   

        teamPoints1 = teamPoints1.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints2 = teamPoints2.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints3 = teamPoints3.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints4 = teamPoints4.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints5 = teamPoints5.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints6 = teamPoints6.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints7 = teamPoints7.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints8 = teamPoints8.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints9 = teamPoints9.GetComponent<TMPro.TextMeshProUGUI>();
        teamPoints10 = teamPoints10.GetComponent<TMPro.TextMeshProUGUI>();        
        

        gamesBehind7 = gamesBehind7.GetComponent<TMPro.TextMeshProUGUI>();
        gamesBehind8 = gamesBehind8.GetComponent<TMPro.TextMeshProUGUI>();
        gamesBehind9 = gamesBehind9.GetComponent<TMPro.TextMeshProUGUI>();
        gamesBehind10 = gamesBehind10.GetComponent<TMPro.TextMeshProUGUI>();

        standingsNameText1 = standingsNameText1.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText2 = standingsNameText2.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText3 = standingsNameText3.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText4 = standingsNameText4.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText5 = standingsNameText5.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText6 = standingsNameText6.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText7 = standingsNameText7.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText8 = standingsNameText8.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText9 = standingsNameText9.GetComponent<TMPro.TextMeshProUGUI>();
        standingsNameText10 = standingsNameText10.GetComponent<TMPro.TextMeshProUGUI>();

        OffRtgText1 = OffRtgText1.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText2 = OffRtgText2.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText3 = OffRtgText3.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText4 = OffRtgText4.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText5 = OffRtgText5.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText6 = OffRtgText6.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText7 = OffRtgText7.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText8 = OffRtgText8.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText9 = OffRtgText9.GetComponent<TMPro.TextMeshProUGUI>();
        OffRtgText10 = OffRtgText10.GetComponent<TMPro.TextMeshProUGUI>();

        DefRtgText1 = DefRtgText1.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText2 = DefRtgText2.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText3 = DefRtgText3.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText4 = DefRtgText4.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText5 = DefRtgText5.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText6 = DefRtgText6.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText7 = DefRtgText7.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText8 = DefRtgText8.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText9 = DefRtgText9.GetComponent<TMPro.TextMeshProUGUI>();
        DefRtgText10 = DefRtgText10.GetComponent<TMPro.TextMeshProUGUI>();

        OvrRtgText1 = OvrRtgText1.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText2 = OvrRtgText2.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText3 = OvrRtgText3.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText4 = OvrRtgText4.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText5 = OvrRtgText5.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText6 = OvrRtgText6.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText7 = OvrRtgText7.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText8 = OvrRtgText8.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText9 = OvrRtgText9.GetComponent<TMPro.TextMeshProUGUI>();
        OvrRtgText10 = OvrRtgText10.GetComponent<TMPro.TextMeshProUGUI>();

        teamPerimeterDefenceText1 = teamPerimeterDefenceText1.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText2 = teamPerimeterDefenceText2.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText3 = teamPerimeterDefenceText3.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText4 = teamPerimeterDefenceText4.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText5 = teamPerimeterDefenceText5.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText6 = teamPerimeterDefenceText6.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText7 = teamPerimeterDefenceText7.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText8 = teamPerimeterDefenceText8.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText9 = teamPerimeterDefenceText9.GetComponent<TMPro.TextMeshProUGUI>();
        teamPerimeterDefenceText10 = teamPerimeterDefenceText10.GetComponent<TMPro.TextMeshProUGUI>();

        teamInDefenceText1 = teamInDefenceText1.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText2 = teamInDefenceText2.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText3 = teamInDefenceText3.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText4 = teamInDefenceText4.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText5 = teamInDefenceText5.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText6 = teamInDefenceText6.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText7 = teamInDefenceText7.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText8 = teamInDefenceText8.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText9 = teamInDefenceText9.GetComponent<TMPro.TextMeshProUGUI>();
        teamInDefenceText10 = teamInDefenceText10.GetComponent<TMPro.TextMeshProUGUI>();

        teamOutscoringText1 = teamOutscoringText1.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText2 = teamOutscoringText2.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText3 = teamOutscoringText3.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText4 = teamOutscoringText4.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText5 = teamOutscoringText5.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText6 = teamOutscoringText6.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText7 = teamOutscoringText7.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText8 = teamOutscoringText8.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText9 = teamOutscoringText9.GetComponent<TMPro.TextMeshProUGUI>();
        teamOutscoringText10 = teamOutscoringText10.GetComponent<TMPro.TextMeshProUGUI>();

        teamInscoringText1 = teamInscoringText1.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText2 = teamInscoringText2.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText3 = teamInscoringText3.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText4 = teamInscoringText4.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText5 = teamInscoringText5.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText6 = teamInscoringText6.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText7 = teamInscoringText7.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText8 = teamInscoringText8.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText9 = teamInscoringText9.GetComponent<TMPro.TextMeshProUGUI>();
        teamInscoringText10 = teamInscoringText10.GetComponent<TMPro.TextMeshProUGUI>();

        playerIssue1 = playerIssue1.GetComponent<TMPro.TextMeshProUGUI>();
        playerIssue2 = playerIssue2.GetComponent<TMPro.TextMeshProUGUI>();
        playerIssue3 = playerIssue3.GetComponent<TMPro.TextMeshProUGUI>();


        /*
        baseStar1 = baseStar1.GetComponent<Image>();
        baseStar2 = baseStar2.GetComponent<Image>();
        baseStar3 = baseStar3.GetComponent<Image>();
        baseStar4 = baseStar4.GetComponent<Image>();
        baseStar5 = baseStar5.GetComponent<Image>();  */      
        
        tradeStar1 = tradeStar1.GetComponent<Image>();
        tradeStar2 = tradeStar2.GetComponent<Image>();
        tradeStar3 = tradeStar3.GetComponent<Image>();
        tradeStar4 = tradeStar4.GetComponent<Image>();
        tradeStar5 = tradeStar5.GetComponent<Image>();        
        tradeStar6 = tradeStar6.GetComponent<Image>();
        tradeStar7 = tradeStar7.GetComponent<Image>();
        tradeStar8 = tradeStar8.GetComponent<Image>();
        tradeStar9 = tradeStar9.GetComponent<Image>();
        tradeStar10 = tradeStar10.GetComponent<Image>();

        lineUpplayerName1 = lineUpplayerName1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName2 = lineUpplayerName2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName3 = lineUpplayerName3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName4 = lineUpplayerName4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName5 = lineUpplayerName5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName6 = lineUpplayerName6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName7 = lineUpplayerName7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName8 = lineUpplayerName8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName9 = lineUpplayerName9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplayerName10 = lineUpplayerName10.GetComponent<TMPro.TextMeshProUGUI>();


        lineUpinsideScoring1 = lineUpinsideScoring1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring2 = lineUpinsideScoring2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring3 = lineUpinsideScoring3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring4 = lineUpinsideScoring4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring5 = lineUpinsideScoring5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring6 = lineUpinsideScoring6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring7 = lineUpinsideScoring7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring8 = lineUpinsideScoring8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring9 = lineUpinsideScoring9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideScoring10 = lineUpinsideScoring10.GetComponent<TMPro.TextMeshProUGUI>();

        lineUpoutsideScoring1 =  lineUpoutsideScoring1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring2 =  lineUpoutsideScoring2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring3 =  lineUpoutsideScoring3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring4 =  lineUpoutsideScoring4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring5 =  lineUpoutsideScoring5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring6 =  lineUpoutsideScoring6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring7 =  lineUpoutsideScoring7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring8 =  lineUpoutsideScoring8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring9 =  lineUpoutsideScoring9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoutsideScoring10 = lineUpoutsideScoring10.GetComponent<TMPro.TextMeshProUGUI>();

        lineUpballHandling1 = lineUpballHandling1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling2 = lineUpballHandling2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling3 = lineUpballHandling3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling4 = lineUpballHandling4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling5 = lineUpballHandling5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling6 = lineUpballHandling6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling7 = lineUpballHandling7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling8 = lineUpballHandling8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling9 = lineUpballHandling9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpballHandling10 = lineUpballHandling10.GetComponent<TMPro.TextMeshProUGUI>();

        lineUpplaymaking1 = lineUpplaymaking1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking2 = lineUpplaymaking2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking3 = lineUpplaymaking3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking4 = lineUpplaymaking4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking5 = lineUpplaymaking5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking6 = lineUpplaymaking6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking7 = lineUpplaymaking7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking8 = lineUpplaymaking8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking9 = lineUpplaymaking9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpplaymaking10 =lineUpplaymaking10.GetComponent<TMPro.TextMeshProUGUI>();

        lineUpinsideDefence1 = lineUpinsideDefence1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence2 = lineUpinsideDefence2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence3 = lineUpinsideDefence3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence4 = lineUpinsideDefence4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence5 = lineUpinsideDefence5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence6 = lineUpinsideDefence6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence7 = lineUpinsideDefence7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence8 = lineUpinsideDefence8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence9 = lineUpinsideDefence9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpinsideDefence10 = lineUpinsideDefence10.GetComponent<TMPro.TextMeshProUGUI>();

        lineUpperimeterDefence1 = lineUpperimeterDefence1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence2 = lineUpperimeterDefence2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence3 = lineUpperimeterDefence3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence4 = lineUpperimeterDefence4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence5 = lineUpperimeterDefence5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence6 = lineUpperimeterDefence6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence7 = lineUpperimeterDefence7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence8 = lineUpperimeterDefence8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence9 = lineUpperimeterDefence9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpperimeterDefence10 = lineUpperimeterDefence10.GetComponent<TMPro.TextMeshProUGUI>();

        lineUpoverall1 = lineUpoverall1.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall2 = lineUpoverall2.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall3 = lineUpoverall3.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall4 = lineUpoverall4.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall5 = lineUpoverall5.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall6 = lineUpoverall6.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall7 = lineUpoverall7.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall8 = lineUpoverall8.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall9 = lineUpoverall9.GetComponent<TMPro.TextMeshProUGUI>();
        lineUpoverall10 = lineUpoverall10.GetComponent<TMPro.TextMeshProUGUI>();

        tradeTeamName = tradeTeamName.GetComponent<TMPro.TextMeshProUGUI>();        
        tradeNumberText = tradeNumberText.GetComponent<TMPro.TextMeshProUGUI>();
        goToNextTrade = goToNextTrade.GetComponent<Button>();
        goToPrevTrade = goToPrevTrade.GetComponent<Button>();
        tradeButton = tradeButton.GetComponent<Button>();

        //Set that this is the first run of the game
        firstRun = true;
        //Set update time
        updateTime = 5.0f;
        //Set timer
        time = 0.0f;
        //Reset lineup editor
        lineupSwapIn = false;
        lineupSwapOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Count time, if update time met, recalculate ratings, standings and player issues
        time += Time.deltaTime;
        if (time >= updateTime)
        {
            calcTeamRatings();
            standingsCalc();
            playerIssues();
            time = 0.0f;
        }
    }

    //Create the roster at the start of the game
    public void createRoster()
    {
        //A star player occurs every 10 entries with increased stats, starting at 5
        int starPlayer = 5;
        //Add to the list of possible first names
        firstNames.Add("John");
        firstNames.Add("Steve");
        firstNames.Add("Michael");
        firstNames.Add("Jimmy");
        firstNames.Add("Alex");
        firstNames.Add("Rudy");
        firstNames.Add("Russ");
        firstNames.Add("Lucas");
        firstNames.Add("Theo");
        firstNames.Add("Patrick");
        firstNames.Add("James");
        firstNames.Add("Fabian");
        firstNames.Add("Mark");
        firstNames.Add("Marcus");
        firstNames.Add("Liam");
        firstNames.Add("Lewis");
        firstNames.Add("Noah");
        firstNames.Add("Nathan");
        firstNames.Add("Robert");
        firstNames.Add("William");
        firstNames.Add("David");
        firstNames.Add("Stephen");
        firstNames.Add("Kevin");
        firstNames.Add("Chris");
        firstNames.Add("Shaquille");
        firstNames.Add("Larry");
        firstNames.Add("Bill");
        firstNames.Add("Oscar");
        firstNames.Add("Carl");
        firstNames.Add("Paul");
        firstNames.Add("Victor");
        firstNames.Add("Kyle");
        firstNames.Add("Duncan");
        firstNames.Add("Will");
        firstNames.Add("Patrick");
        //Add to list of possible second names
        surnames.Add("Jones");
        surnames.Add("House");
        surnames.Add("Smith");
        surnames.Add("Richards");
        surnames.Add("Jordan");
        surnames.Add("Chambers");
        surnames.Add("Howard");
        surnames.Add("Oliver");
        surnames.Add("Peterson");
        surnames.Add("Rowe");
        surnames.Add("Phillips");
        surnames.Add("Davis");
        surnames.Add("Brown");
        surnames.Add("Williams");
        surnames.Add("Miller");
        surnames.Add("Johnson");
        surnames.Add("Campbell");
        surnames.Add("Murray");
        surnames.Add("Clarke");
        surnames.Add("Walker");
        surnames.Add("Henderson");
        surnames.Add("George");
        surnames.Add("Bird");
        surnames.Add("Thompson");
        surnames.Add("Green");
        surnames.Add("Griffin");
        surnames.Add("Nash");
        surnames.Add("Anthony");
        surnames.Add("Robinson");
        surnames.Add("Barnes");
        surnames.Add("Harris");
        surnames.Add("Cook");
        surnames.Add("Grant");
        surnames.Add("Adams");
        surnames.Add("Love");
        surnames.Add("Young");
        surnames.Add("Holiday");



        //Create 100 entries, one for each player
        for (int i = 0; i != 100; i++)
        {
            //Generate player details
            //Create one player with higher stats every 10 players to balance teams
            if (i == starPlayer)
            {
                //Pick a number between the values and assign to the players stats
                int randomNumber = rnd.Next(80, 99);
                insideScoringRtg.Add(randomNumber);
                int randomNumber1 = rnd.Next(80, 99);
                outsideScoringRtg.Add(randomNumber1);
                int randomNumber2 = rnd.Next(80, 99);
                playmakingRtg.Add(randomNumber2);
                int randomNumber3 = rnd.Next(80, 99);
                ballHandlingRtg.Add(randomNumber3);
                int randomNumber4 = rnd.Next(80, 99);
                insideDefRtg.Add(randomNumber4);
                int randomNumber5 = rnd.Next(80, 99);
                perimeterDefRtg.Add(randomNumber5);
                //Default OVR to 0, will be calculated later
                ovrRtg.Add(0);
                //Default happiness to 80
                happiness.Add(80);
                starPlayer = starPlayer + 10;
            }
            else
            {
                int randomNumber = rnd.Next(50, 99);
                insideScoringRtg.Add(randomNumber);
                int randomNumber1 = rnd.Next(50, 99);
                outsideScoringRtg.Add(randomNumber1);
                int randomNumber2 = rnd.Next(50, 99);
                playmakingRtg.Add(randomNumber2);
                int randomNumber3 = rnd.Next(50, 99);
                ballHandlingRtg.Add(randomNumber3);
                int randomNumber4 = rnd.Next(50, 99);
                insideDefRtg.Add(randomNumber4);
                int randomNumber5 = rnd.Next(50, 99);
                perimeterDefRtg.Add(randomNumber5);
                ovrRtg.Add(0);
                happiness.Add(80);
            }            

            //Generate player name
            int randomFirstName = rnd.Next(0, 35);
            int randomSurname = rnd.Next(0, 37);
            //Add name to list and then combine
            string newFirstName = firstNames[randomFirstName];
            string newSecondName = surnames[randomSurname];
            string newName = string.Concat(newFirstName," ", newSecondName);
            playerNames.Add(newName);

            //Set player to team
            if (i < 10) 
            {
                teamName.Add("London");
            }            
            else if (i < 20) 
            {
                teamName.Add("Paris");
            }            
            else if (i < 30) 
            {
                teamName.Add("Madrid");
            }            
            else if (i < 40) 
            {
                teamName.Add("Milan");
            }            
            else if (i < 50) 
            {
                teamName.Add("Wien");
            }            
            else if (i < 60) 
            {
                teamName.Add("Berlin");
            }            
            else if (i < 70) 
            {
                teamName.Add("Dublin");
            }            
            else if (i < 80) 
            {
                teamName.Add("Oslo");
            }            
            else if (i < 90) 
            {
                teamName.Add("Budapest");
            }            
            else if (i < 100) 
            {
                teamName.Add("Lisbon");
            }       

        }
        //Set every teams record to 0
        for (int i = 0; i != 10; i++)
        {
            teamWins.Add(0);
            teamLosses.Add(0);
            teamPoints.Add(0);
        }
    }

    //Calculate overall ratings via average
    public void ratingCalculate()
    {
        
        for (int i = 0; i != 100; i++)
        {
            int overall = insideScoringRtg[i] + outsideScoringRtg[i] + playmakingRtg[i] + ballHandlingRtg[i] + insideDefRtg[i] + perimeterDefRtg[i];
            overall = overall / 6;
            ovrRtg[i] = overall;
        }
        //Calculate each teams average ratings
        calcTeamRatings();
    }

    //A function which will set all placeholders to be the user's team
    public void homeRoster()
    {
        playerName1.text = playerNames[0];
        playerName2.text = playerNames[1];
        playerName3.text = playerNames[2];
        playerName4.text = playerNames[3];
        playerName5.text = playerNames[4];
        playerName6.text = playerNames[5];
        playerName7.text = playerNames[6];
        playerName8.text = playerNames[7];
        playerName9.text = playerNames[8];
        playerName10.text = playerNames[9];        
        
        insideScoring1.text = insideScoringRtg[0].ToString();
        insideScoring2.text = insideScoringRtg[1].ToString();
        insideScoring3.text = insideScoringRtg[2].ToString();
        insideScoring4.text = insideScoringRtg[3].ToString();
        insideScoring5.text = insideScoringRtg[4].ToString();
        insideScoring6.text = insideScoringRtg[5].ToString();
        insideScoring7.text = insideScoringRtg[6].ToString();
        insideScoring8.text = insideScoringRtg[7].ToString();
        insideScoring9.text = insideScoringRtg[8].ToString();
        insideScoring10.text = insideScoringRtg[9].ToString();

        outsideScoring1.text = outsideScoringRtg[0].ToString();
        outsideScoring2.text = outsideScoringRtg[1].ToString();
        outsideScoring3.text = outsideScoringRtg[2].ToString();
        outsideScoring4.text = outsideScoringRtg[3].ToString();
        outsideScoring5.text = outsideScoringRtg[4].ToString();
        outsideScoring6.text = outsideScoringRtg[5].ToString();
        outsideScoring7.text = outsideScoringRtg[6].ToString();
        outsideScoring8.text = outsideScoringRtg[7].ToString();
        outsideScoring9.text = outsideScoringRtg[8].ToString();
        outsideScoring10.text = outsideScoringRtg[9].ToString();

        ballHandling1.text = ballHandlingRtg[0].ToString();
        ballHandling2.text = ballHandlingRtg[1].ToString();
        ballHandling3.text = ballHandlingRtg[2].ToString();
        ballHandling4.text = ballHandlingRtg[3].ToString();
        ballHandling5.text = ballHandlingRtg[4].ToString();
        ballHandling6.text = ballHandlingRtg[5].ToString();
        ballHandling7.text = ballHandlingRtg[6].ToString();
        ballHandling8.text = ballHandlingRtg[7].ToString();
        ballHandling9.text = ballHandlingRtg[8].ToString();
        ballHandling10.text = ballHandlingRtg[9].ToString();

        playmaking1.text = playmakingRtg[0].ToString();
        playmaking2.text = playmakingRtg[1].ToString();
        playmaking3.text = playmakingRtg[2].ToString();
        playmaking4.text = playmakingRtg[3].ToString();
        playmaking5.text = playmakingRtg[4].ToString();
        playmaking6.text = playmakingRtg[5].ToString();
        playmaking7.text = playmakingRtg[6].ToString();
        playmaking8.text = playmakingRtg[7].ToString();
        playmaking9.text = playmakingRtg[8].ToString();
        playmaking10.text = playmakingRtg[9].ToString();
                                                 
        insideDefence1.text = insideDefRtg[0].ToString();
        insideDefence2.text = insideDefRtg[1].ToString();
        insideDefence3.text = insideDefRtg[2].ToString();
        insideDefence4.text = insideDefRtg[3].ToString();
        insideDefence5.text = insideDefRtg[4].ToString();
        insideDefence6.text = insideDefRtg[5].ToString();
        insideDefence7.text = insideDefRtg[6].ToString();
        insideDefence8.text = insideDefRtg[7].ToString();
        insideDefence9.text = insideDefRtg[8].ToString();
        insideDefence10.text = insideDefRtg[9].ToString();

        perimeterDefence1.text = perimeterDefRtg[0].ToString();
        perimeterDefence2.text = perimeterDefRtg[1].ToString();
        perimeterDefence3.text = perimeterDefRtg[2].ToString();
        perimeterDefence4.text = perimeterDefRtg[3].ToString();
        perimeterDefence5.text = perimeterDefRtg[4].ToString();
        perimeterDefence6.text = perimeterDefRtg[5].ToString();
        perimeterDefence7.text = perimeterDefRtg[6].ToString();
        perimeterDefence8.text = perimeterDefRtg[7].ToString();
        perimeterDefence9.text = perimeterDefRtg[8].ToString();
        perimeterDefence10.text = perimeterDefRtg[9].ToString();        
        
        overall1.text = ovrRtg[0].ToString();
        overall2.text = ovrRtg[1].ToString();
        overall3.text = ovrRtg[2].ToString();
        overall4.text = ovrRtg[3].ToString();
        overall5.text = ovrRtg[4].ToString();
        overall6.text = ovrRtg[5].ToString();
        overall7.text = ovrRtg[6].ToString();
        overall8.text = ovrRtg[7].ToString();
        overall9.text = ovrRtg[8].ToString();
        overall10.text = ovrRtg[9].ToString();


    }

    //Make user team's players appear in the trade finder screen
    public void tradeFinder()
    {
        calcTradeValue();

        tradePlayerName1.text = playerNames[0];
        tradePlayerName2.text = playerNames[1];
        tradePlayerName3.text = playerNames[2];
        tradePlayerName4.text = playerNames[3];
        tradePlayerName5.text = playerNames[4];
        tradePlayerName6.text = playerNames[5];
        tradePlayerName7.text = playerNames[6];
        tradePlayerName8.text = playerNames[7];
        tradePlayerName9.text = playerNames[8];
        tradePlayerName10.text = playerNames[9];

        tradeOverall1.text = ovrRtg[0].ToString();
        tradeOverall2.text = ovrRtg[1].ToString();
        tradeOverall3.text = ovrRtg[2].ToString();
        tradeOverall4.text = ovrRtg[3].ToString();
        tradeOverall5.text = ovrRtg[4].ToString();
        tradeOverall6.text = ovrRtg[5].ToString();
        tradeOverall7.text = ovrRtg[6].ToString();
        tradeOverall8.text = ovrRtg[7].ToString();
        tradeOverall9.text = ovrRtg[8].ToString();
        tradeOverall10.text = ovrRtg[9].ToString();        
        
        happiness1.text = happiness[0].ToString();
        happiness2.text = happiness[1].ToString();
        happiness3.text = happiness[2].ToString();
        happiness4.text = happiness[3].ToString();
        happiness5.text = happiness[4].ToString();
        happiness6.text = happiness[5].ToString();
        happiness7.text = happiness[6].ToString();
        happiness8.text = happiness[7].ToString();
        happiness9.text = happiness[8].ToString();
        happiness10.text = happiness[9].ToString();


    }
    //Make user team's players appear in lineup editor menu
    public void lineUpEditor()
    {
        lineUpplayerName1.text = playerNames[0];
        lineUpplayerName2.text = playerNames[1];
        lineUpplayerName3.text = playerNames[2];
        lineUpplayerName4.text = playerNames[3];
        lineUpplayerName5.text = playerNames[4];
        lineUpplayerName6.text = playerNames[5];
        lineUpplayerName7.text = playerNames[6];
        lineUpplayerName8.text = playerNames[7];
        lineUpplayerName9.text = playerNames[8];
        lineUpplayerName10.text = playerNames[9];
        
        lineUpinsideScoring1.text = insideScoringRtg[0].ToString();
        lineUpinsideScoring2.text = insideScoringRtg[1].ToString();
        lineUpinsideScoring3.text = insideScoringRtg[2].ToString();
        lineUpinsideScoring4.text = insideScoringRtg[3].ToString();
        lineUpinsideScoring5.text = insideScoringRtg[4].ToString();
        lineUpinsideScoring6.text = insideScoringRtg[5].ToString();
        lineUpinsideScoring7.text = insideScoringRtg[6].ToString();
        lineUpinsideScoring8.text = insideScoringRtg[7].ToString();
        lineUpinsideScoring9.text = insideScoringRtg[8].ToString();
        lineUpinsideScoring10.text = insideScoringRtg[9].ToString();
        
        lineUpoutsideScoring1.text = outsideScoringRtg[0].ToString();
        lineUpoutsideScoring2.text = outsideScoringRtg[1].ToString();
        lineUpoutsideScoring3.text = outsideScoringRtg[2].ToString();
        lineUpoutsideScoring4.text = outsideScoringRtg[3].ToString();
        lineUpoutsideScoring5.text = outsideScoringRtg[4].ToString();
        lineUpoutsideScoring6.text = outsideScoringRtg[5].ToString();
        lineUpoutsideScoring7.text = outsideScoringRtg[6].ToString();
        lineUpoutsideScoring8.text = outsideScoringRtg[7].ToString();
        lineUpoutsideScoring9.text = outsideScoringRtg[8].ToString();
        lineUpoutsideScoring10.text = outsideScoringRtg[9].ToString();
        
        lineUpballHandling1.text = ballHandlingRtg[0].ToString();
        lineUpballHandling2.text = ballHandlingRtg[1].ToString();
        lineUpballHandling3.text = ballHandlingRtg[2].ToString();
        lineUpballHandling4.text = ballHandlingRtg[3].ToString();
        lineUpballHandling5.text = ballHandlingRtg[4].ToString();
        lineUpballHandling6.text = ballHandlingRtg[5].ToString();
        lineUpballHandling7.text = ballHandlingRtg[6].ToString();
        lineUpballHandling8.text = ballHandlingRtg[7].ToString();
        lineUpballHandling9.text = ballHandlingRtg[8].ToString();
        lineUpballHandling10.text = ballHandlingRtg[9].ToString();
        
        lineUpplaymaking1.text = playmakingRtg[0].ToString();
        lineUpplaymaking2.text = playmakingRtg[1].ToString();
        lineUpplaymaking3.text = playmakingRtg[2].ToString();
        lineUpplaymaking4.text = playmakingRtg[3].ToString();
        lineUpplaymaking5.text = playmakingRtg[4].ToString();
        lineUpplaymaking6.text = playmakingRtg[5].ToString();
        lineUpplaymaking7.text = playmakingRtg[6].ToString();
        lineUpplaymaking8.text = playmakingRtg[7].ToString();
        lineUpplaymaking9.text = playmakingRtg[8].ToString();
        lineUpplaymaking10.text = playmakingRtg[9].ToString();
        
        lineUpinsideDefence1.text = insideDefRtg[0].ToString();
        lineUpinsideDefence2.text = insideDefRtg[1].ToString();
        lineUpinsideDefence3.text = insideDefRtg[2].ToString();
        lineUpinsideDefence4.text = insideDefRtg[3].ToString();
        lineUpinsideDefence5.text = insideDefRtg[4].ToString();
        lineUpinsideDefence6.text = insideDefRtg[5].ToString();
        lineUpinsideDefence7.text = insideDefRtg[6].ToString();
        lineUpinsideDefence8.text = insideDefRtg[7].ToString();
        lineUpinsideDefence9.text = insideDefRtg[8].ToString();
        lineUpinsideDefence10.text = insideDefRtg[9].ToString();
        
        lineUpperimeterDefence1.text = perimeterDefRtg[0].ToString();
        lineUpperimeterDefence2.text = perimeterDefRtg[1].ToString();
        lineUpperimeterDefence3.text = perimeterDefRtg[2].ToString();
        lineUpperimeterDefence4.text = perimeterDefRtg[3].ToString();
        lineUpperimeterDefence5.text = perimeterDefRtg[4].ToString();
        lineUpperimeterDefence6.text = perimeterDefRtg[5].ToString();
        lineUpperimeterDefence7.text = perimeterDefRtg[6].ToString();
        lineUpperimeterDefence8.text = perimeterDefRtg[7].ToString();
        lineUpperimeterDefence9.text = perimeterDefRtg[8].ToString();
        lineUpperimeterDefence10.text = perimeterDefRtg[9].ToString();

        lineUpoverall1.text = ovrRtg[0].ToString();
        lineUpoverall2.text = ovrRtg[1].ToString();
        lineUpoverall3.text = ovrRtg[2].ToString();
        lineUpoverall4.text = ovrRtg[3].ToString();
        lineUpoverall5.text = ovrRtg[4].ToString();
        lineUpoverall6.text = ovrRtg[5].ToString();
        lineUpoverall7.text = ovrRtg[6].ToString();
        lineUpoverall8.text = ovrRtg[7].ToString();
        lineUpoverall9.text = ovrRtg[8].ToString();
        lineUpoverall10.text = ovrRtg[9].ToString();
    }
    //Calculate the trade value of each player in the game by taking their overall rating and subtracting a number if their happiness is below certain thresholds
    public void calcTradeValue()
    {
        tradeValue.Clear();
        for (int i = 0; i != 100; i++)
        {
            int overall = ovrRtg[i];
            int happy = happiness[i];
            int tradeVal;
            if (happy >= 80)
                tradeVal = overall;
            else if (happy >= 60)
                tradeVal = overall - 5;
            else if (happy >= 40)
                tradeVal = overall - 10;
            else if (happy >= 20)
                tradeVal = overall - 15;
            else
                tradeVal = overall - 20;

            tradeValue.Add(tradeVal);
        }
        //Set each players value as stars
        tradeStars();
    }

    //Translate each player's value into a star rating for simplicity
    public void tradeStars()
    {
        //For each player on the user team, set the star value to match the trade value, and update sprite to show correct number of stars
        for (int i = 0; i != 10; i++)
        {
            int starValue = tradeValue[i];
            int numberOfStars;
            if (starValue >= 85)
                numberOfStars = 5;
            else if (starValue >= 75)
                numberOfStars = 4;
            else if (starValue >= 60)
                numberOfStars = 3;
            else if (starValue >= 40)
                numberOfStars = 2;
            else
                numberOfStars = 1;

            if (i == 0)
            {
                if (numberOfStars == 4)
                    tradeStar1.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar1.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar1.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar1.sprite = oneStar;
            }            

            if (i == 1)
            {
                if (numberOfStars == 4)
                    tradeStar2.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar2.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar2.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar2.sprite = oneStar;
            }

            if (i == 2)
            {
                if (numberOfStars == 4)
                    tradeStar3.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar3.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar3.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar3.sprite = oneStar;
            }

            if (i == 3)
            {
                if (numberOfStars == 4)
                    tradeStar4.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar4.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar4.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar4.sprite = oneStar;
            }

            if (i == 4)
            {
                if (numberOfStars == 4)
                    tradeStar5.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar5.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar5.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar5.sprite = oneStar;
            }

            if (i == 5)
            {
                if (numberOfStars == 4)
                    tradeStar6.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar6.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar6.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar6.sprite = oneStar;
            }

            if (i == 6)
            {
                if (numberOfStars == 4)
                    tradeStar7.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar7.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar7.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar7.sprite = oneStar;
            }

            if (i == 7)
            {
                if (numberOfStars == 4)
                    tradeStar8.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar8.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar8.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar8.sprite = oneStar;
            }

            if (i == 8)
            {
                if (numberOfStars == 4)
                    tradeStar9.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar9.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar9.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar9.sprite = oneStar;
            }

            if (i == 9)
            {
                if (numberOfStars == 4)
                    tradeStar10.sprite = fourStar;
                if (numberOfStars == 3)
                    tradeStar10.sprite = threeStar;
                if (numberOfStars == 2)
                    tradeStar10.sprite = twoStar;
                if (numberOfStars == 1)
                    tradeStar10.sprite = oneStar;
            }
        }
    }
    //A series of functions relating to trading each player on the roster.
    public void tradePlayerOne()
    {
        //Set player 1 to be the name and rating in the trade finder, then set the player being traded and start the trade function
        tradeOfferName.text = playerNames[0];
        tradeOfferOvr.text = ovrRtg[0].ToString();
        playerTraded = 0;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);

    }    
    
    public void tradePlayerTwo()
    {
        tradeOfferName.text = playerNames[1];
        tradeOfferOvr.text = ovrRtg[1].ToString();
        playerTraded = 1;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }    
    public void tradePlayerThree()
    {
        tradeOfferName.text = playerNames[2];
        tradeOfferOvr.text = ovrRtg[2].ToString();
        playerTraded = 2;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }
    public void tradePlayerFour()
    {
        tradeOfferName.text = playerNames[3];
        tradeOfferOvr.text = ovrRtg[3].ToString();
        playerTraded = 3;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }
    public void tradePlayerFive()
    {
        tradeOfferName.text = playerNames[4];
        tradeOfferOvr.text = ovrRtg[4].ToString();
        playerTraded = 4;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }
    public void tradePlayerSix()
    {
        tradeOfferName.text = playerNames[5];
        tradeOfferOvr.text = ovrRtg[5].ToString();
        playerTraded = 5;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }
    public void tradePlayerSeven()
    {
        tradeOfferName.text = playerNames[6];
        tradeOfferOvr.text = ovrRtg[6].ToString();
        playerTraded = 6;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }
    public void tradePlayerEight()
    {
        tradeOfferName.text = playerNames[7];
        tradeOfferOvr.text = ovrRtg[7].ToString();
        playerTraded = 7;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }
    public void tradePlayerNine()
    {
        tradeOfferName.text = playerNames[8];
        tradeOfferOvr.text = ovrRtg[8].ToString();
        playerTraded = 8;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }
    public void tradePlayerTen()
    {
        tradeOfferName.text = playerNames[9];
        tradeOfferOvr.text = ovrRtg[9].ToString();
        playerTraded = 9;
        tradeNumber = 10;
        goingForward = true;
        tradeCount = 0;
        totalTrades = 0;
        showTrade(playerTraded, tradeNumber);
    }

    //Flick forward to the next available trade offer. If you reach the last trade offer, return to the first
    public void NextTrade()
    {
        goingForward = true;
        tradeNumber = tradeNumber + 1;
        
        if (tradeNumber == 100)
        {
            tradeNumber = 10;
        }
        showTrade(playerTraded, tradeNumber);
        
    }    
    //Go back to the previous trade offer, if you reach the first, go to the last
    public void PrevTrade()
    {
        goingForward = false;
        tradeNumber = tradeNumber - 1;
        if (tradeNumber == 9)
        {
            tradeNumber = 99;
        }
        showTrade(playerTraded, tradeNumber);
        
    }
    //Show the trade being offered in the right hand panel of trade finder
    public void showTrade(int playerBeingTraded, int tradeNum)
    {
        //Set boundaries for a trade, it will search 3 up and down from the player being traded's value
        int lowerBoundary = tradeValue[tradeNum] - 3;
        int higherBoundary = tradeValue[tradeNum] + 3;
        totalTrades = 0;
        //For every player that fits the trade, increase number of trades
        for (int i = 10; i != 100; i++)
        {
            if (tradeValue[playerBeingTraded] >= tradeValue[i] -3 && tradeValue[playerBeingTraded] <= tradeValue[i] + 3)
            {
                totalTrades = totalTrades + 1;
            }
        }
        //Cycle through trades, if it reaches the final trade, go back to the first
        if (tradeValue[playerBeingTraded] >= lowerBoundary && tradeValue[playerBeingTraded] <= higherBoundary)
        {
            if (goingForward == true)
            {
                tradeCount = tradeCount + 1;
                if (tradeCount == totalTrades + 1)
                {
                    tradeCount = 1;
                }
            }
            else 
            { 
                tradeCount = tradeCount - 1;       
                if (tradeCount == 0)
                    {
                        tradeCount = totalTrades;
                    }
            }
            //Set the trade details for the player being offered to user team
            tradeReceiveName.text = playerNames[tradeNum];
            tradeReceiveOvr.text = ovrRtg[tradeNum].ToString();
            tradeTeamName.text = teamName[tradeNum];
            tradeNumberText.text = $"Trade {tradeCount.ToString()} of {totalTrades.ToString()}";
            Debug.Log("Success");
        }
        //If the player being looked at doesn't fit the trade boundaries, find the next trade
        else
        {
            Debug.Log("Player not in range");
            if (goingForward == true)
            {
                NextTrade();
            }
            else
            {
                PrevTrade();
            }
            
        }
    }

    //Swap the players in the database if the user wants to go ahead with a trade
    public void performTrade()
    {
        //Create the database ID of the player joining and leaving
        int playerLeaving;
        int playerJoining;
        //Creat temporary storage
        int tempNum;
        int tempNum2;
        int tempNum3;
        int tempNum4;
        int tempNum5;
        int tempNum6;
        int tempNum7;
        string tempString;
        //Set the ID's
        playerLeaving = playerTraded;
        playerJoining = tradeNumber;
        //Write the trade to console
        Debug.Log($"{playerNames[playerTraded]} is being traded for {playerNames[tradeNumber]}");

        //Set temp storage to the player joining, then replace their details with the player leaving, then move the temp storage to the player who left the team
        tempString = playerNames[tradeNumber];

        playerNames[tradeNumber] = playerNames[playerTraded];
        playerNames[playerTraded] = tempString;        

        tempNum = insideScoringRtg[tradeNumber];
        insideScoringRtg[tradeNumber] = insideScoringRtg[playerTraded];
        insideScoringRtg[playerTraded] = tempNum;        
        
        tempNum2 = outsideScoringRtg[tradeNumber];
        outsideScoringRtg[tradeNumber] = outsideScoringRtg[playerTraded];
        outsideScoringRtg[playerTraded] = tempNum2;        
        
        tempNum3 = playmakingRtg[tradeNumber];
        playmakingRtg[tradeNumber] = playmakingRtg[playerTraded];
        playmakingRtg[playerTraded] = tempNum3;        
        
        tempNum4 = ballHandlingRtg[tradeNumber];
        ballHandlingRtg[tradeNumber] = ballHandlingRtg[playerTraded];
        ballHandlingRtg[playerTraded] = tempNum4;        
        
        tempNum5 = insideDefRtg[tradeNumber];
        insideDefRtg[tradeNumber] = insideDefRtg[playerTraded];
        insideDefRtg[playerTraded] = tempNum5;        
        
        tempNum6 = perimeterDefRtg[tradeNumber];
        perimeterDefRtg[tradeNumber] = perimeterDefRtg[playerTraded];
        perimeterDefRtg[playerTraded] = tempNum6;        
        
        tempNum7 = ovrRtg[tradeNumber];
        ovrRtg[tradeNumber] = ovrRtg[playerTraded];
        ovrRtg[playerTraded] = tempNum7;
        //Reset happiness for each player
        happiness[tradeNumber] = 80;
        happiness[playerTraded] = 80;

        //Reset screens to show the new players
        homeRoster();
        tradeFinder();
        calcTeamRatings();
        //Reset trade finder screen
        tradeOfferName.text = "";
        tradeOfferOvr.text = "";
        tradeReceiveName.text = "";
        tradeReceiveOvr.text = "";
        tradeTeamName.text = "";
        tradeNumberText.text = "";

    }

    //Calculate team averages, these can be used to create gameplans on how to beat specific teams
    public void calcTeamRatings()
    {
        //Set the first and last player of the first team
        int playerCounter = 0;
        int lastPlayer = 10;
        //Reset all averages
        teamOffense.Clear();
        teamDefence.Clear();
        teamInDefence.Clear();
        teamPerimDefence.Clear();
        teamInScoring.Clear();
        teamOutScoring.Clear();
        teamOvr.Clear();
        //For each team
        for (int i = 0; i != 10; i++)
        {
            //Create combined number of a stat
            int combinedOvr = 0;
            int combinedOffense = 0;
            int combinedDefence = 0;
            int combinedInScoring = 0;
            int combinedOutScoring = 0;
            int combinedInDefence = 0;
            int combinedPerimDefence = 0;
            //Go through each player on the team, add to the combined stat
            while (playerCounter != lastPlayer)
            {
                combinedOffense = combinedOffense + insideScoringRtg[playerCounter] + outsideScoringRtg[playerCounter] + ballHandlingRtg[playerCounter] + playmakingRtg[playerCounter];
                combinedDefence = combinedDefence + insideDefRtg[playerCounter] + perimeterDefRtg[playerCounter];
                combinedInScoring = combinedInScoring + insideScoringRtg[playerCounter];
                combinedOutScoring = combinedOutScoring + outsideScoringRtg[playerCounter];
                combinedInDefence = combinedInDefence + insideDefRtg[playerCounter];
                combinedPerimDefence = combinedPerimDefence + perimeterDefRtg[playerCounter];

                combinedOvr = combinedOvr + ovrRtg[playerCounter];
                playerCounter++;

            }
            //Divide by the number of stats used to find an average
            int teamOffavg = combinedOffense / 40;
            int teamDefAvg = combinedDefence / 20;
            int teamOvrAvg = combinedOvr / 10;
            int teamOutScoringAvg = combinedOutScoring / 10;
            int teamInScoringAvg = combinedInScoring / 10;
            int teamInDefenceAvg = combinedInDefence / 10;
            int teamPerimDefenceAvg = combinedPerimDefence / 10;
            //Add each average to the corresponding list
            teamOffense.Add(teamOffavg);
            teamDefence.Add(teamDefAvg);
            teamOvr.Add(teamOvrAvg);
            teamInScoring.Add(teamInScoringAvg);
            teamOutScoring.Add(teamOutScoringAvg);
            teamInDefence.Add(teamInDefenceAvg);
            teamPerimDefence.Add(teamPerimDefenceAvg);
            //Go to the next team
            lastPlayer = lastPlayer + 10;
        }
    }

    //Calculate the league standings in order of team with most wins to fewest
    public void standingsCalc()
    {
        //If it is the first run, set team 6 wins to 0 as this is used to calculate games behind
        if (firstRun==true)
        {
            teamSixWins = 0;
        }
        //For each team
        for ( int i = 0; i != 10; i++)
        {
            //Start the team at position 10, then compare them to each team ahead of them, if they have more wins, move them up a place
            int currentPosition = 10;
            for (int comparingTeam = 0; comparingTeam != 10; comparingTeam++)
            {
                if (teamWins[i] > teamWins[comparingTeam] )
                {
                    currentPosition = currentPosition - 1;
                }
                //If wins are equal, team with fewer losses is placed higher, this can be used for if there is a staggering of games, so teams can play at different times
                else if (teamWins[i] == teamWins[comparingTeam])
                {
                    if (teamLosses[i] < teamLosses[comparingTeam])
                    {
                        currentPosition = currentPosition - 1;
                    }
                    //If losses are also equal, the team with more points will be higher in the standings
                    else if (teamLosses[i]  == teamLosses[comparingTeam])
                    {
                        if (teamPoints[i] > teamPoints[comparingTeam])
                        {
                            currentPosition = currentPosition - 1;

                        }
                    }
                }
            }
            //Set each teams details to their place in the standings
            if (i == 0 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); 
                    teamlosses1.text = teamLosses[i].ToString();
                    teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "London";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); 
                    teamlosses2.text = teamLosses[i].ToString();
                    teamPoints2.text = teamPoints[i].ToString();

                    standingsNameText2.text = "London";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString(); teamPoints3.text = teamPoints[i].ToString();

                    standingsNameText3.text = "London";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString(); teamPoints4.text = teamPoints[i].ToString();

                    standingsNameText4.text = "London";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString(); teamPoints5.text = teamPoints[i].ToString();

                    standingsNameText5.text = "London";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString(); teamPoints6.text = teamPoints[i].ToString();

                    standingsNameText6.text = "London";
                    teamSixWins = teamWins[i];
                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString(); teamPoints7.text = teamPoints[i].ToString();

                    standingsNameText7.text = "London";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();

                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString(); teamPoints8.text = teamPoints[i].ToString();

                    standingsNameText8.text = "London";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();

                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString(); teamPoints9.text = teamPoints[i].ToString();

                    standingsNameText9.text = "London";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();

                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString(); teamPoints10.text = teamPoints[i].ToString();

                    standingsNameText10.text = "London";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();


                }
            }
            if (i == 1 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();

                    standingsNameText1.text = "Paris";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Paris";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Paris";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Paris";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Paris";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Paris";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Paris";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Paris";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Paris";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Paris";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 2 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Madrid";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Madrid";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Madrid";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Madrid";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Madrid";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Madrid";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Madrid";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Madrid";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Madrid";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Madrid";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 3 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Milan";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Milan";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Milan";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Milan";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Milan";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Milan";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Milan";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Milan";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Milan";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Milan";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 4 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Wien";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Wien";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Wien";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Wien";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Wien";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Wien";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Wien";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Wien";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Wien";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Wien";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 5 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Berlin";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Berlin";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Berlin";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Berlin";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Berlin";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Berlin";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Berlin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Berlin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Berlin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Berlin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 6 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Dublin";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Dublin";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Dublin";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Dublin";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Dublin";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Dublin";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Dublin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Dublin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Dublin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Dublin";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 7 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Oslo";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Oslo";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Oslo";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Oslo";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Oslo";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Oslo";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Oslo";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Oslo";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Oslo";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Oslo";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 8 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Budapest";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Budapest";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Budapest";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Budapest";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Budapest";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Budapest";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Budapest";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Budapest";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Budapest";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Budapest";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            if (i == 9 )
            {
                if (currentPosition == 1)
                {
                    teamWins1.text = teamWins[i].ToString(); teamlosses1.text = teamLosses[i].ToString(); teamPoints1.text = teamPoints[i].ToString();
                    standingsNameText1.text = "Lisbon";
                }         
                
                if (currentPosition == 2)
                {
                    teamWins2.text = teamWins[i].ToString(); teamlosses2.text = teamLosses[i].ToString();teamPoints2.text = teamPoints[i].ToString();
                    standingsNameText2.text = "Lisbon";
                }                
                if (currentPosition == 3)
                {
                    teamWins3.text = teamWins[i].ToString(); teamlosses3.text = teamLosses[i].ToString();teamPoints3.text = teamPoints[i].ToString();
                    standingsNameText3.text = "Lisbon";
                }                
                if (currentPosition == 4)
                {
                    teamWins4.text = teamWins[i].ToString(); teamlosses4.text = teamLosses[i].ToString();teamPoints4.text = teamPoints[i].ToString();
                    standingsNameText4.text = "Lisbon";
                }                
                
                if (currentPosition == 5)
                {
                    teamWins5.text = teamWins[i].ToString(); teamlosses5.text = teamLosses[i].ToString();teamPoints5.text = teamPoints[i].ToString();
                    standingsNameText5.text = "Lisbon";
                }                
                if (currentPosition == 6)
                {
                    teamWins6.text = teamWins[i].ToString(); teamlosses6.text = teamLosses[i].ToString();teamPoints6.text = teamPoints[i].ToString();
                    standingsNameText6.text = "Lisbon";
                    teamSixWins = teamWins[i];

                }
                if (currentPosition == 7)
                {
                    teamWins7.text = teamWins[i].ToString(); teamlosses7.text = teamLosses[i].ToString();teamPoints7.text = teamPoints[i].ToString();
                    standingsNameText7.text = "Lisbon";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind7.text = winsNeeded.ToString();
                }
                if (currentPosition == 8)
                {
                    teamWins8.text = teamWins[i].ToString(); teamlosses8.text = teamLosses[i].ToString();teamPoints8.text = teamPoints[i].ToString();
                    standingsNameText8.text = "Lisbon";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind8.text = winsNeeded.ToString();
                }
                if (currentPosition == 9)
                {
                    teamWins9.text = teamWins[i].ToString(); teamlosses9.text = teamLosses[i].ToString();teamPoints9.text = teamPoints[i].ToString();
                    standingsNameText9.text = "Lisbon";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind9.text = winsNeeded.ToString();
                }
                if (currentPosition == 10)
                {
                    teamWins10.text = teamWins[i].ToString(); teamlosses10.text = teamLosses[i].ToString();teamPoints10.text = teamPoints[i].ToString();
                    standingsNameText10.text = "Lisbon";
                    int winsNeeded = teamSixWins - teamWins[i];
                    gamesBehind10.text = winsNeeded.ToString();
                }
            }
            
            //New games behind calculation, above was giving negative results.
            //Convert 6 7 8 9 10 wins from the placeholder to a string
            string sixWins = teamWins6.text;
            string sevenWins = teamWins7.text;
            string eightWins = teamWins8.text;
            string nineWins = teamWins9.text;
            string tenWins = teamWins10.text;
            //Convert these strings to integers for calculations
            int six = int.Parse(sixWins);
            int seven = int.Parse(sevenWins);
            int eight = int.Parse(eightWins);
            int nine = int.Parse(nineWins);
            int ten = int.Parse(tenWins);
            //Take each teams wins from team 6 to find how far behind
            int gamesBehindSix7 = six - seven;
            int gamesBehindSix8 = six - eight;
            int gamesBehindSix9 = six - nine;
            int gamesBehindSix10 = six - ten;
            //Present to screen
            gamesBehind7.text = gamesBehindSix7.ToString();
            gamesBehind8.text = gamesBehindSix8.ToString();
            gamesBehind9.text = gamesBehindSix9.ToString();
            gamesBehind10.text = gamesBehindSix10.ToString();
            

        }
    }



    //Display the stats of each team in the league
    public void showTeamRatings()
    {
        OffRtgText1.text = teamOffense[0].ToString();
        DefRtgText1.text = teamDefence[0].ToString();
        OvrRtgText1.text = teamOvr[0].ToString();
        teamOutscoringText1.text = teamOutScoring[0].ToString();
        teamInscoringText1.text = teamInScoring[0].ToString();
        teamInDefenceText1.text = teamInDefence[0].ToString();
        teamPerimeterDefenceText1.text = teamPerimDefence[0].ToString();


        OffRtgText2.text = teamOffense[1].ToString();
        DefRtgText2.text = teamDefence[1].ToString();
        OvrRtgText2.text = teamOvr[1].ToString();
        teamOutscoringText2.text = teamOutScoring[1].ToString();
        teamInscoringText2.text = teamInScoring[1].ToString();
        teamInDefenceText2.text = teamInDefence[1].ToString();
        teamPerimeterDefenceText2.text = teamPerimDefence[1].ToString();

        OffRtgText3.text = teamOffense[2].ToString();
        DefRtgText3.text = teamDefence[2].ToString();
        OvrRtgText3.text = teamOvr[2].ToString();
        teamOutscoringText3.text = teamOutScoring[2].ToString();
        teamInscoringText3.text = teamInScoring[2].ToString();
        teamInDefenceText3.text = teamInDefence[2].ToString();
        teamPerimeterDefenceText3.text = teamPerimDefence[2].ToString();

        OffRtgText4.text = teamOffense[3].ToString();
        DefRtgText4.text = teamDefence[3].ToString();
        OvrRtgText4.text = teamOvr[3].ToString();
        teamOutscoringText4.text = teamOutScoring[3].ToString();
        teamInscoringText4.text = teamInScoring[3].ToString();
        teamInDefenceText4.text = teamInDefence[3].ToString();
        teamPerimeterDefenceText4.text = teamPerimDefence[3].ToString();

        OffRtgText5.text = teamOffense[4].ToString();
        DefRtgText5.text = teamDefence[4].ToString();
        OvrRtgText5.text = teamOvr[4].ToString();
        teamOutscoringText5.text = teamOutScoring[4].ToString();
        teamInscoringText5.text = teamInScoring[4].ToString();
        teamInDefenceText5.text = teamInDefence[4].ToString();
        teamPerimeterDefenceText5.text = teamPerimDefence[4].ToString();

        OffRtgText6.text = teamOffense[5].ToString();
        DefRtgText6.text = teamDefence[5].ToString();
        OvrRtgText6.text = teamOvr[5].ToString();
        teamOutscoringText6.text = teamOutScoring[5].ToString();
        teamInscoringText6.text = teamInScoring[5].ToString();
        teamInDefenceText6.text = teamInDefence[5].ToString();
        teamPerimeterDefenceText6.text = teamPerimDefence[5].ToString();

        OffRtgText7.text = teamOffense[6].ToString();
        DefRtgText7.text = teamDefence[6].ToString();
        OvrRtgText7.text = teamOvr[6].ToString();
        teamOutscoringText7.text = teamOutScoring[6].ToString();
        teamInscoringText7.text = teamInScoring[6].ToString();
        teamInDefenceText7.text = teamInDefence[6].ToString();
        teamPerimeterDefenceText7.text = teamPerimDefence[6].ToString();

        OffRtgText8.text = teamOffense[7].ToString();
        DefRtgText8.text = teamDefence[7].ToString();
        OvrRtgText8.text = teamOvr[7].ToString();
        teamOutscoringText8.text = teamOutScoring[7].ToString();
        teamInscoringText8.text = teamInScoring[7].ToString();
        teamInDefenceText8.text = teamInDefence[7].ToString();
        teamPerimeterDefenceText8.text = teamPerimDefence[7].ToString();

        OffRtgText9.text = teamOffense[8].ToString();
        DefRtgText9.text = teamDefence[8].ToString();
        OvrRtgText9.text = teamOvr[8].ToString();
        teamOutscoringText9.text = teamOutScoring[8].ToString();
        teamInscoringText9.text = teamInScoring[8].ToString();
        teamInDefenceText9.text = teamInDefence[8].ToString();
        teamPerimeterDefenceText9.text = teamPerimDefence[8].ToString();

        OffRtgText10.text = teamOffense[9].ToString();
        DefRtgText10.text = teamDefence[9].ToString();
        OvrRtgText10.text = teamOvr[9].ToString();
        teamOutscoringText10.text = teamOutScoring[9].ToString();
        teamInscoringText10.text = teamInScoring[9].ToString();
        teamInDefenceText10.text = teamInDefence[9].ToString();
        teamPerimeterDefenceText10.text = teamPerimDefence[9].ToString();
    }

    //Calculate if any player has a happiness issue, if they do, display this on the home screen
    public void playerIssues()
    {
        //Other teams players are always set to 80 happiness, so default this, the issue is the ID of the player with issue 1, 2 or 3
        issue1 = 10;
        issue2 = 10;
        issue3 = 10;
        //For each player on the user's team, if happiness is under 50, see if there is room on the issue list, if so, add the issue, if not, only add if the player is less happy than one of the current issues
        for (int i = 0; i != 10;i++)
        {
            if (happiness[i] <= 50)
            {
                if (happiness[i] <= happiness[issue1])
                {
                    issue3 = issue2;
                    issue2 = issue1;
                    issue1 = i;
                }
                else if (happiness[i] <= happiness[issue2])
                {
                    issue3 = issue2;
                    issue2 = i;
                }
                else if (happiness[i] <= happiness[issue3])
                {
                    issue3 = i;
                    
                }
            }
        }
        //Set the player to the issue screen
        playerIssue1.text = $"{playerNames[issue1].ToString()}  - \n{happiness[issue1].ToString()} happiness";
        playerIssue2.text = $"{playerNames[issue2].ToString()} - \n{happiness[issue2].ToString()} happiness";
        playerIssue3.text = $"{playerNames[issue3].ToString()} - \n{happiness[issue3].ToString()} happiness";



        if (happiness[issue3] > 50)
        {
            playerIssue3.text = "No more issues";
        }
        if (happiness[issue2] > 50)
        {
            playerIssue2.text = "No more issues";
            playerIssue3.text = "";
        }
        if (happiness[issue1] > 50)
        {
            playerIssue1.text = "No issues";
            playerIssue2.text = "";
            playerIssue3.text = "";
        }


    }
    //Functions for swapping a player in or out of the lineup
    //Players 1 to 5 are lineupOut as these are in the starting lineup already, so will be removed
    public void switchPlayerOne()
    {
        lineupOut = 0;
        lineupSwapOut = true;
        changeLineup();
    }    
    public void switchPlayerTwo()
    {
        lineupOut = 1;
        lineupSwapOut = true;
        changeLineup();
    }
    public void switchPlayerThree()
    {
        lineupOut = 2;
        lineupSwapOut = true;
        changeLineup();
    }
    public void switchPlayerFour()
    {
        lineupOut = 3;
        lineupSwapOut = true;
        changeLineup();
    }
    public void switchPlayerFive()
    {
        lineupOut = 4;
        lineupSwapOut = true;
        changeLineup();
    }
    //Players 6 to 10 are lineupIn as these are in the substitutes so will be added to the starting lineup
    public void switchPlayerSix()
    {
        lineupIn = 5;
        lineupSwapIn = true;
        changeLineup();
    }
    public void switchPlayerSeven()
    {
        lineupIn = 6;
        lineupSwapIn = true;
        changeLineup();
    }
    public void switchPlayerEight()
    {
        lineupIn = 7;
        lineupSwapIn = true;
        changeLineup();
    }
    public void switchPlayerNine()
    {
        lineupIn = 8;
        lineupSwapIn = true;
        changeLineup();
    }
    public void switchPlayerTen()
    {
        lineupIn = 9;
        lineupSwapIn = true;
        changeLineup();
    }

    //Make a change to the starting lineup
    public void changeLineup()
    {

        //If a player to be swapped in and out are both ready, proceed
        if (lineupSwapIn == true && lineupSwapOut == true)
        {
            //Same system as trade, store player going out of lineup's details to a temporary placeholder then replace with the new player and set the temp storage to the new starter's old space
            int tempNum;
            int tempNum2;
            int tempNum3;
            int tempNum4;
            int tempNum5;
            int tempNum6;
            int tempNum7;
            string tempString;


            Debug.Log($"{playerNames[lineupIn]} is being moved into lineup for {playerNames[lineupOut]}");


            tempString = playerNames[lineupOut];

            playerNames[lineupOut] = playerNames[lineupIn];
            playerNames[lineupIn] = tempString;

            tempNum = insideScoringRtg[lineupOut];
            insideScoringRtg[lineupOut] = insideScoringRtg[lineupIn];
            insideScoringRtg[lineupIn] = tempNum;

            tempNum2 = outsideScoringRtg[lineupOut];
            outsideScoringRtg[lineupOut] = outsideScoringRtg[lineupIn];
            outsideScoringRtg[lineupIn] = tempNum2;

            tempNum3 = playmakingRtg[lineupOut];
            playmakingRtg[lineupOut] = playmakingRtg[lineupIn];
            playmakingRtg[lineupIn] = tempNum3;

            tempNum4 = ballHandlingRtg[lineupOut];
            ballHandlingRtg[lineupOut] = ballHandlingRtg[lineupIn];
            ballHandlingRtg[lineupIn] = tempNum4;

            tempNum5 = insideDefRtg[lineupOut];
            insideDefRtg[lineupOut] = insideDefRtg[lineupIn];
            insideDefRtg[lineupIn] = tempNum5;

            tempNum6 = perimeterDefRtg[lineupOut];
            perimeterDefRtg[lineupOut] = perimeterDefRtg[lineupIn];
            perimeterDefRtg[lineupIn] = tempNum6;

            tempNum7 = ovrRtg[lineupOut];
            ovrRtg[lineupOut] = ovrRtg[lineupIn];
            ovrRtg[lineupIn] = tempNum7;

            //Reset readiness so that another swap doesnt happen by accident
            lineupSwapOut = false;
            lineupSwapIn = false;
            lineupOut = -1;
            lineupIn = -1;
            //Reload lineup screen so the swap appears
            lineUpEditor();
        }
        
    }
}
