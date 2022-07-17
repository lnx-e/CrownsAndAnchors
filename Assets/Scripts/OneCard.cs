using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OneCard : MonoBehaviour
{
    public int symbolCoins = 0;
    public int bufferCoins;
    public TextMeshProUGUI symbolCoinsText;
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

    // Start is called before the first frame update
    void Start()
    {
        diceOne = GameObject.Find("DICE1");
        diceTwo = GameObject.Find("DICE2");
        diceThree = GameObject.Find("DICE3");
    }

    // Update is called once per frame
    void Update()
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
    }

    public void PayingOut()
    {
        Debug.Log("oneCard");
        if (diceOneValue == 1 && diceTwoValue == 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 4;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;

            Debug.Log("1");
            
        }

        else if (diceOneValue == 1 && diceTwoValue == 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;


            Debug.Log("2");

        }

        else if (diceOneValue == 1 && diceTwoValue != 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;

            Debug.Log("3");
            
        }

        else if (diceOneValue != 1 && diceTwoValue == 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;

            Debug.Log("4");
            

        }

        else if (diceOneValue == 1 && diceTwoValue != 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;


            Debug.Log("5");

        }

        else if (diceOneValue != 1 && diceTwoValue == 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;

            Debug.Log("6");
            

        }

        else if (diceOneValue != 1 && diceTwoValue != 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;

            Debug.Log("7");
            

        }
        
        else if (diceOneValue != 1 && diceTwoValue != 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 0;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;
            bufferCoins = 0;

            Debug.Log("8");
            

        }
        
    }

    private void OnMouseDown()
    {
        AddingCoins();
    }

    private void AddingCoins()
    {
        if (GameLogic.playerCoins > 0 && toPutCoins == true)
        {
            GameLogic.playerCoins--;
            symbolCoins++;
        }
    }
}
