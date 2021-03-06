using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Symbol : MonoBehaviour
{
    [SerializeField]
    private int symbolValue;

    public int symbolCoins = 0;
    private int bufferCoins = 0;
    public static int previousRoll = 0;
    public TextMeshProUGUI symbolCoinsText;
    public TextMeshProUGUI previousRollWinText;
    public static bool toPutCoins = true;

    public GameObject diceOne;
    public GameObject diceTwo;
    public GameObject diceThree;

    public int diceOneValue = 0;
    public int diceTwoValue = 0;
    public int diceThreeValue = 0;

    public int lastDiceOne = 0;
    public int lastDiceTwo = 0;
    public int lastDiceThree = 0;

    public AudioSource coinSound;
    public AudioSource epicWin;
    public AudioSource win;

    public GameObject JackPot;
    

    private void Start()
    {
        diceOne = GameObject.Find("DICE1");
        diceTwo = GameObject.Find("DICE2");
        diceThree = GameObject.Find("DICE3");
  
    }

    private void Update()
    {
        symbolCoinsText.text = symbolCoins.ToString();

        lastDiceOne = diceOneValue;
        lastDiceTwo = diceTwoValue;
        lastDiceThree = diceThreeValue;

        diceOneValue = diceOne.GetComponent<Dice>().finalSide;
        diceTwoValue = diceTwo.GetComponent<Dice>().finalSide;
        diceThreeValue = diceThree.GetComponent<Dice>().finalSide;

        if (lastDiceOne != diceOneValue || lastDiceTwo != diceTwoValue || lastDiceThree != diceThreeValue)
        {
            PayingOut();
        }

        lastDiceOne = 0;
        lastDiceTwo = 0;
        lastDiceThree = 0;

        GameLogic.previousRollWin = previousRoll;
        
    }

    
    public void PayingOut()
    {
        if (diceOneValue == symbolValue && diceTwoValue == symbolValue && diceThreeValue == symbolValue)
        {
            if (symbolCoins >= 1) { epicWin.Play(); }
            bufferCoins = symbolCoins * 4;
            GameLogic.playerCoins += bufferCoins;
            
            symbolCoins = 0;
            if(symbolCoins == 10)
            {
                Dice.diceSound.Stop();
                GameLogic.GameOverBGr.SetActive(true);
                GameLogic.RestartButtonr.SetActive(true);
                GameLogic.ExitButtonr.SetActive(true);
            }
            

            Debug.Log(symbolValue + " 1");

        }

        if (diceOneValue == symbolValue && diceTwoValue == symbolValue && diceThreeValue != symbolValue)
        {
            if (symbolCoins >= 1) { win.Play(); }
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
           
            symbolCoins = 0;

            Debug.Log(symbolValue + " 2");

        }

        if (diceOneValue == symbolValue && diceTwoValue != symbolValue && diceThreeValue == symbolValue)
        {
            if (symbolCoins >= 1) { win.Play(); }
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            
            symbolCoins = 0; 

            Debug.Log(symbolValue + " 3");

        }

        if (diceOneValue != symbolValue && diceTwoValue == symbolValue && diceThreeValue == symbolValue)
        {
            if (symbolCoins >= 1) { win.Play(); }
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            
            symbolCoins = 0;
            

            Debug.Log(symbolValue + " 4");

        }

        if (diceOneValue == symbolValue && diceTwoValue != symbolValue && diceThreeValue != symbolValue)
        {
            if (symbolCoins >= 1) { win.Play(); }
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            
            symbolCoins = 0;
            

            Debug.Log(symbolValue + " 5");

        }

        else if (diceOneValue != symbolValue && diceTwoValue == symbolValue && diceThreeValue != symbolValue)
        {
            if (symbolCoins >= 1) { win.Play(); }
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            
            symbolCoins = 0;
            

            Debug.Log(symbolValue + " 6");

        }

        if (diceOneValue != symbolValue && diceTwoValue != symbolValue && diceThreeValue == symbolValue)
        {
            if (symbolCoins >= 1) { win.Play(); }
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            
            symbolCoins = 0;
            

            Debug.Log(symbolValue + " 7");

        }

        if (diceOneValue != symbolValue && diceTwoValue != symbolValue && diceThreeValue != symbolValue)
        {
            bufferCoins = symbolCoins * 0;
            GameLogic.playerCoins += bufferCoins;
            
            symbolCoins = 0;
            

            Debug.Log(symbolValue + " 8");

        }
        previousRoll += bufferCoins;
        bufferCoins = 0;

    }
    private void OnMouseDown()
    {
        if (symbolCoins <= 9)
        {
            AddingCoins();
        }
        
    }

    private void AddingCoins()
    {
        if (GameLogic.playerCoins > 0 && toPutCoins == true)
        {
            GameLogic.playerCoins--;
            symbolCoins++;
            coinSound.Play();

        }        
    }
}
