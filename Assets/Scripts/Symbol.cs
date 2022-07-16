using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Symbol : MonoBehaviour
{
    [SerializeField]
    private int symbolValue;

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

    private void Start()
    {
        diceOne = GameObject.Find("DICE1");
        diceTwo = GameObject.Find("DICE2");
        diceThree = GameObject.Find("DICE3");
  
    }

    private void Update()
    {
        symbolCoinsText.text = symbolCoins.ToString();

        diceOneValue = diceOne.GetComponent<Dice>().diceValue;
        diceTwoValue = diceTwo.GetComponent<Dice>().diceValue;
        diceThreeValue = diceThree.GetComponent<Dice>().diceValue;    
        if(Dice.diceRolled == true)
        {
            if (diceOneValue == symbolValue && diceTwoValue == symbolValue && diceThreeValue == symbolValue)
            {
                bufferCoins = symbolCoins * 4;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("1");

            }

            else if (diceOneValue == symbolValue && diceTwoValue == symbolValue && diceThreeValue != symbolValue)
            {
                bufferCoins = symbolCoins * 3;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("2");

            }

            else if (diceOneValue == symbolValue && diceTwoValue != symbolValue && diceThreeValue == symbolValue)
            {
                bufferCoins = symbolCoins * 3;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("3");

            }

            else if (diceOneValue != symbolValue && diceTwoValue == symbolValue && diceThreeValue == symbolValue)
            {
                bufferCoins = symbolCoins * 3;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("4");

            }

            else if (diceOneValue == symbolValue && diceTwoValue != symbolValue && diceThreeValue != symbolValue)
            {
                bufferCoins = symbolCoins * 2;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("5");

            }

            else if (diceOneValue != symbolValue && diceTwoValue == symbolValue && diceThreeValue != symbolValue)
            {
                bufferCoins = symbolCoins * 2;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("6");

            }

            else if (diceOneValue != symbolValue && diceTwoValue != symbolValue && diceThreeValue == symbolValue)
            {
                bufferCoins = symbolCoins * 2;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("7");

            }

            else if (diceOneValue != symbolValue && diceTwoValue != symbolValue && diceThreeValue != symbolValue)
            {
                bufferCoins = symbolCoins * 0;
                GameLogic.playerCoins += bufferCoins;
                symbolCoins = 0;

                //Debug.Log("8");

            }
            Dice.diceRolled = false;
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

    public void PayingOut()
    {              
        Dice.diceRolled = false;
    }
}
