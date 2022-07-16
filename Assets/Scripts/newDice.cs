using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newDice : MonoBehaviour
{
    public Sprite[] diceSides;
    private SpriteRenderer rend;
    public int diceValue;
    public static bool diceRolled = false;

    public OneCard oneCard;
    public GameObject FirstCard;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        oneCard = FirstCard.GetComponent<OneCard>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            diceValue = Random.Range(0, 6);

            rend.sprite = diceSides[diceValue];
            oneCard.PayingOut();
        }
    }
}
