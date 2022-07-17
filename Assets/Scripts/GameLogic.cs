using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{

    public static int playerCoins;
    public TextMeshProUGUI playerCoinsText;

    public static int previousRollWin = 0;
    public TextMeshProUGUI previousRollWinText;


    // Start is called before the first frame update
    void Start()
    {
        playerCoins = 25;

    }

    // Update is called once per frame
    void Update()
    {
        playerCoinsText.text = playerCoins.ToString();
        previousRollWinText.text = previousRollWin.ToString();
    }
}
