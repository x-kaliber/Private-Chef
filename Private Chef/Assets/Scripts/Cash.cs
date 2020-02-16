using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cash : MonoBehaviour
{
    public Text Income;

    public static int moneyAmount;
    // Start is called before the first frame update
    void Start()
    {
       // moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {
        Income.text = moneyAmount.ToString();
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }

}
