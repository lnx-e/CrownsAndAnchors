using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameLogic : MonoBehaviour
{

    public static int playerCoins;
    public TextMeshProUGUI playerCoinsText;

    public static int previousRollWin = 0;
    public TextMeshProUGUI previousRollWinText;

    public GameObject SymbolOne;
    public GameObject SymbolTwo;
    public GameObject SymbolThree;
    public GameObject SymbolFour;
    public GameObject SymbolFive;
    public GameObject SymbolSix;

    public int symbolOneCoins = 0;
    public int symbolTwoCoins = 0;
    public int symbolThreeCoins = 0;
    public int symbolFourCoins = 0;
    public int symbolFiveCoins = 0;
    public int symbolSixCoins = 0;



    public GameObject GameOverBG;
    public GameObject GameOverText;
    public GameObject RestartButton;
    public GameObject ExitButton;
    public GameObject infoScreen;

    public static GameObject GameOverBGr;
    public static GameObject RestartButtonr;
    public static GameObject ExitButtonr;

    public AudioSource GameOverSound;

    private bool switchText = true;

    // Start is called before the first frame update
    void Start()
    {
        playerCoins = 5;
        SymbolOne = GameObject.Find("Symbol 1");
        SymbolTwo = GameObject.Find("Symbol 2");
        SymbolThree = GameObject.Find("Symbol 3");
        SymbolFour = GameObject.Find("Symbol 4");
        SymbolFive = GameObject.Find("Symbol 5");
        SymbolSix = GameObject.Find("Symbol 6");

        GameOverBGr = GameOverBG;
        RestartButtonr = RestartButton;
        ExitButtonr = ExitButton;
    }

    // Update is called once per frame
    void Update()
    {
        symbolOneCoins = SymbolOne.GetComponent<Symbol>().symbolCoins;
        symbolTwoCoins = SymbolTwo.GetComponent<Symbol>().symbolCoins;
        symbolThreeCoins = SymbolThree.GetComponent<Symbol>().symbolCoins;
        symbolFourCoins = SymbolFour.GetComponent<Symbol>().symbolCoins;
        symbolFiveCoins = SymbolFive.GetComponent<Symbol>().symbolCoins;
        symbolSixCoins = SymbolSix.GetComponent<Symbol>().symbolCoins;

        if (symbolOneCoins == 0 && symbolTwoCoins == 0 && symbolThreeCoins == 0 && symbolFourCoins == 0 && symbolFiveCoins == 0 && symbolSixCoins == 0 && playerCoins == 0)
        {
            Dice.diceSound.Stop();
            GameOverSound.Play();
            GameOverBG.SetActive(true);
            GameOverText.SetActive(true);
            RestartButton.SetActive(true);
            ExitButton.SetActive(true);
        }

        playerCoinsText.text = playerCoins.ToString();
        previousRollWinText.text = previousRollWin.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Debug.Log("over");           
        Application.Quit();
    }

    public void InfoScreen()
    {
        switchText = !switchText;


        if (switchText)
        {
            infoScreen.SetActive(true);
        }
        else
        {
            infoScreen.SetActive(false);
        }
    }
}
