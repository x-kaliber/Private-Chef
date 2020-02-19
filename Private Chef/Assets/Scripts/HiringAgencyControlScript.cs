using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HiringAgencyControlScript : MonoBehaviour
{
    int moneyAmount;
    int isChefHired = 0;
    int isCelebrityChefHired;
    int Cost;
    int StartingFunds;
    int HiredChefs = 0;
    int HiredCelebrityChefs = 0;


    public Text CostText;
    public Text StartingFundsText;
    public Text moneyAmountText;
    public Text CelebrityChefPrice;
    public Text ChefPrice;


    public Button HireCelebrityBtn;
    public Button HireBtn;

    // Use this for initialization
    void Start()
    {
        Cost = PlayerPrefs.GetInt("TotalCost");
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        StartingFunds = PlayerPrefs.GetInt("MoneyAmount");

    }

    // Update is called once per frame
    void Update()
    {

        StartingFundsText.text = "Avaliable Funds : " + StartingFunds.ToString() + "$";
        moneyAmountText.text = "Current Funds :  " + Cash.moneyAmount.ToString() + "$";
        CostText.text = "I have spend : " + Cost.ToString() + "$";

        isChefHired = PlayerPrefs.GetInt("isChefHired");
        isCelebrityChefHired = PlayerPrefs.GetInt("isCelebrityChefHired");


        if (Cash.moneyAmount >= 1000000)// we set the conditions for setting the button active for  Celebrity chef
        {
            if (isCelebrityChefHired == 1)
            {
                if (HiredCelebrityChefs == 0)
                {
                    HireCelebrityBtn.interactable = true;
                }
            }
        }
        else
            HireCelebrityBtn.interactable = false;

        if (Cash.moneyAmount >= 10000)// we set the conditions for setting the button active for  chef
        {
            if (isChefHired == 1)
            {
                if (HiredChefs == 0)
                {
                    HireBtn.interactable = true;
                }
            }
        }
        else
            HireBtn.interactable = false;
    }

    public void HireCelebrityChef()
    {
        Cash.moneyAmount -= 1000000;
        Cost += 1000000;
        HiredCelebrityChefs += 1;
        PlayerPrefs.SetInt("isCelebrityChefHired", 1);
        CelebrityChefPrice.text = "Hired!";
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        HireBtn.interactable = false;
    }
    public void HireChef()
    {
        Cash.moneyAmount -= 10000;
        Cost += 10000;
        HiredChefs += 1;
        PlayerPrefs.SetInt("isChefHired", 1);
        ChefPrice.text = "Hired!";
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        HireBtn.interactable = false;
    }

    public void Office() // We call Office Scene
    {

        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        PlayerPrefs.SetInt("TotalCost", Cost);
        PlayerPrefs.SetInt("StartingFunds", StartingFunds);
        SceneManager.LoadScene("Office");
    }

    public void HomeB() // We call the main menu Scene
    {
        SceneManager.LoadScene(0);
    }
}
