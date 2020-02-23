using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StagesScript : MonoBehaviour
{
    int moneyAmount;
    int Cost;

    public Button HotDogCartBtn;
    public Button PastaCartBtn;
    public Text moneyAmountText;

    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("GoldCoins");
    }

    void Update()
    {
        moneyAmountText.text = "Current Funds :  " + Cash.GoldCoins.ToString() + "." + Cash.CopperCoins.ToString() + "$";


        if (Cash.GoldCoins >= 1000)// we set the conditions for setting the button active for Hot Dog
        {

                HotDogCartBtn.interactable = true;

        }
        else
            HotDogCartBtn.interactable = false;

        if (Cash.GoldCoins >= 2000)// we set the conditions for setting the button active for Hot Dog
        {

            PastaCartBtn.interactable = true;

        }
        else
            PastaCartBtn.interactable = false;
    }

    public void Home()//We call the Start Menu
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void PlayGame() // We call the main Game
    {
        SceneManager.LoadScene("MainGame");
    }

    public void PlayHotDogGame() // We call the Hot Dog Game
    {
        Cash.GoldCoins -= 5000;
        Cost += 5000;
        PlayerPrefs.SetInt("GoldCoins", moneyAmount);
        SceneManager.LoadScene("HotDogCart");
    }

    public void PlayPastaGame() // We call the Pasta Game
    {
        Cash.GoldCoins -= 7000;
        Cost += 7000;
        PlayerPrefs.SetInt("GoldCoins", moneyAmount);
        SceneManager.LoadScene("PastaCart");
    }
}
