using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cash : MonoBehaviour
{
    int HiredChef;
    public Text Income;

    public static int GoldCoins;
    public static int CopperCoins;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HiredChef = PlayerPrefs.GetInt("isChefHired");
        if(HiredChef == 2)
        {
            if(Cash.CopperCoins >= 50 && Cash.CopperCoins <= 60)
            {
                CopperCoins += 1;
                Debug.Log("You got 4% extra money");
            }
        }
        if(Cash.CopperCoins >= 99)
        {
            GoldCoins += 1;
            CopperCoins -= 99;
        }
        Income.text = GoldCoins.ToString() + "." + CopperCoins.ToString();
        PlayerPrefs.SetInt("GoldCoins", GoldCoins);
        PlayerPrefs.SetInt("CopperCoins", CopperCoins);
    }

}
