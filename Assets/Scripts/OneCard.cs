using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OneCard : MonoBehaviour
{
    public int symbolCoins = 0;
    private int bufferCoins;
    public TextMeshProUGUI symbolCoinsText;
    public static bool toPutCoins = true;

    public GameObject diceOne;
    public GameObject diceTwo;
    public GameObject diceThree;

    public int diceOneValue;
    public int diceTwoValue;
    public int diceThreeValue;

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

        diceOneValue = diceOne.GetComponent<Dice>().finalSide;
        diceTwoValue = diceTwo.GetComponent<Dice>().finalSide;
        diceThreeValue = diceThree.GetComponent<Dice>().finalSide;

        //if (newDice.diceRolled == true)
        {
            //PayingOut();
        }
    }

    public void PayingOut()
    {
        Debug.Log("oneCard");
        if (diceOneValue == 1 && diceTwoValue == 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 4;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            Debug.Log("1");
            newDice.diceRolled = false;
        }

        if (diceOneValue == 1 && diceTwoValue == 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            newDice.diceRolled = false;
            Debug.Log("2");

        }

        if (diceOneValue == 1 && diceTwoValue != 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            Debug.Log("3");
            newDice.diceRolled = false;
        }

        if (diceOneValue != 1 && diceTwoValue == 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            Debug.Log("4");
            newDice.diceRolled = false;

        }

        if (diceOneValue == 1 && diceTwoValue != 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            newDice.diceRolled = false;
            Debug.Log("5");

        }

        if (diceOneValue != 1 && diceTwoValue == 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            Debug.Log("6");
            newDice.diceRolled = false;

        }

        if (diceOneValue != 1 && diceTwoValue != 1 && diceThreeValue == 1)
        {
            bufferCoins = symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            Debug.Log("7");
            newDice.diceRolled = false;

        }
        
        if (diceOneValue != 1 && diceTwoValue != 1 && diceThreeValue != 1)
        {
            bufferCoins = symbolCoins * 0;
            GameLogic.playerCoins += bufferCoins;
            symbolCoins = 0;

            Debug.Log("8");
            newDice.diceRolled = false;

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
