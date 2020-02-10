using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour
{
    public void RewardedAds() // We watch the rewarded ads
    {
        Debug.Log("Watched an ad");
    }

    public void Store() // we go to the in game store
    {
        Debug.Log("Went to the store");
    }

    public void Inventory() // we go to the character inventory
    {
        Debug.Log("Checked my Inventory");
    }

    public void Equipment() // we go to the Character Equipment
    {
        Debug.Log("Checked my Equipment");
    }

    public void HireAdvertiser() // we can buy a permanent buff and ad removal
    {
        Debug.Log("Hired an advertiser");
    }

    public void FoodCart() // Buy temporary buff with in game money
    {
        Debug.Log("Rented a Food Cart");
    }
}
