using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
   Text income;
   Text expenses;
   Text total;

    public static int ExpensesAmount;
    public static int PointsAmount;

    void Start()
    {
        income = GetComponent<Text>();
        expenses = GetComponent<Text>();
        total = GetComponent<Text>();

    }

    void Update()
    {
        income.text = Cash.CashAmount.ToString();
        expenses.text = ExpensesAmount.ToString();
        total.text = (Cash.CashAmount - ExpensesAmount).ToString();
    }
}
