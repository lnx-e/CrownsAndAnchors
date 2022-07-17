using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newDice : MonoBehaviour
{
    public Sprite[] diceSides;
    private SpriteRenderer rend;
    public int randomDiceValue;
    public int realDiceValue;
    public static bool diceRolled = false;

    public OneCard oneCard;
    public GameObject FirstCard;


    private int bufferCoins;

    public GameObject diceOne;
    public GameObject diceTwo;
    public GameObject diceThree;

    public int diceOneValue;
    public int diceTwoValue;
    public int diceThreeValue;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        oneCard = FirstCard.GetComponent<OneCard>();

        diceOne = GameObject.Find("DICE1 (1)");
        diceTwo = GameObject.Find("DICE1 (2)");
        diceThree = GameObject.Find("DICE1 (3)");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomDiceValue = Random.Range(0, 6);
            realDiceValue = randomDiceValue + 1;
            rend.sprite = diceSides[randomDiceValue];
            diceRolled = true;
        }
       
    }

    /*public void PayingOut()
    {
        diceOneValue = diceOne.GetComponent<newDice>().realDiceValue;
        diceTwoValue = diceTwo.GetComponent<newDice>().realDiceValue;
        diceThreeValue = diceThree.GetComponent<newDice>().realDiceValue;

        Debug.Log("oneCard");
        if (diceOneValue == 1 && diceTwoValue == 1 && diceThreeValue == 1)
        {
            bufferCoins = OneCard.symbolCoins * 4;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            Debug.Log("1");
            newDice.diceRolled = false;
        }

        if (diceOneValue == 1 && diceTwoValue == 1 && diceThreeValue != 1)
        {
            bufferCoins = OneCard.symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            newDice.diceRolled = false;
            Debug.Log("2");

        }

        if (diceOneValue == 1 && diceTwoValue != 1 && diceThreeValue == 1)
        {
            bufferCoins = OneCard.symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            Debug.Log("3");
            newDice.diceRolled = false;
        }

        if (diceOneValue != 1 && diceTwoValue == 1 && diceThreeValue == 1)
        {
            bufferCoins = OneCard.symbolCoins * 3;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            Debug.Log("4");
            newDice.diceRolled = false;

        }

        if (diceOneValue == 1 && diceTwoValue != 1 && diceThreeValue != 1)
        {
            bufferCoins = OneCard.symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            newDice.diceRolled = false;
            Debug.Log("5");

        }

        if (diceOneValue != 1 && diceTwoValue == 1 && diceThreeValue != 1)
        {
            bufferCoins = OneCard.symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            Debug.Log("6");
            newDice.diceRolled = false;

        }

        if (diceOneValue != 1 && diceTwoValue != 1 && diceThreeValue == 1)
        {
            bufferCoins = OneCard.symbolCoins * 2;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            Debug.Log("7");
            newDice.diceRolled = false;

        }

        if (diceOneValue != 1 && diceTwoValue != 1 && diceThreeValue != 1)
        {
            bufferCoins = OneCard.symbolCoins * 0;
            GameLogic.playerCoins += bufferCoins;
            OneCard.symbolCoins = 0;

            Debug.Log("8");
            newDice.diceRolled = false;

        }

    }*/
}
