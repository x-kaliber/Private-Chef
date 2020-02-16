using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HiringAgencyControlScript : MonoBehaviour
{
    int moneyAmount;
    int isChefHired;
    int isCelebrityChefHired;
    int Cost;
    int StartingFunds;

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

        if (StartingFunds >= 1000000 && moneyAmount >= 1000000 && isCelebrityChefHired == 1) // we set the conditions for setting the button active for Celebrity chef
            HireCelebrityBtn.interactable = true;
        else
            HireCelebrityBtn.interactable = false;

        if (StartingFunds >= 10000 && moneyAmount >= 10000 && isChefHired == 1)// we set the conditions for setting the button active for  chef
            HireBtn.interactable = true;
        else
            HireBtn.interactable = false;
    }

    public void HireCelebrityChef()
    {
        moneyAmount -= 1000000;
        Cost += 1000000;
        PlayerPrefs.SetInt("isCelebrityChefHired", 1);
        CelebrityChefPrice.text = "Hired!";
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        HireCelebrityBtn.gameObject.SetActive(false);
    }
    public void HireChef()
    {
        moneyAmount -= 10000;
        Cost += 10000;
        PlayerPrefs.SetInt("isChefHired", 1);
        ChefPrice.text = "Hired!";
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        HireBtn.gameObject.SetActive(false);
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
