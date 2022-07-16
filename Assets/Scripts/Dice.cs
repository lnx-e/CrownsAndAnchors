using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    // Array of dice sides sprites to load from Resources folder
    public Sprite[] diceSides;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

    public int diceValue;
    public int finalSide = 0;

    public static bool diceRolled = false;

    private OneCard symbol1;
    private Symbol symbol2;
    private Symbol symbol3;
    private Symbol symbol4;
    private Symbol symbol5;
    private Symbol symbol6;


    public GameObject symbol11;
    public GameObject symbol22;
    public GameObject symbol33;
    public GameObject symbol44;
    public GameObject symbol55;
    public GameObject symbol66;

    // Use this for initialization
    private void Start () {

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        symbol1 = symbol11.GetComponent<OneCard>();
        symbol2 = symbol22.GetComponent<Symbol>();
        symbol3 = symbol33.GetComponent<Symbol>();
        symbol4 = symbol44.GetComponent<Symbol>();
        symbol5 = symbol55.GetComponent<Symbol>();
        symbol6 = symbol66.GetComponent<Symbol>();
    }
	
    // If you left click over the dice then RollTheDice coroutine is started
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Symbol.toPutCoins = false;
            StartCoroutine("RollTheDice");
        }

        
        /*if (diceRolled == true)
        {
            symbol1.PayingOut();
            symbol2.PayingOut();
            symbol3.PayingOut();
            symbol4.PayingOut();
            symbol5.PayingOut();
            symbol6.PayingOut();
            diceRolled = false;
        }*/
    }

    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        
        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide = randomDiceSide + 1;

        Symbol.toPutCoins = true;

        //symbol1.PayingOut();
    }
}
