using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour
{
    public GameObject RewardedAdv;
    public GameObject Market;
    public GameObject Inventory;
    public GameObject Equipment;
    public GameObject Chef;
    public GameObject RentMyBusiness;

    public void RewardedAds() // We watch the rewarded ads
    {
        if (RewardedAdv != null)
        {
            RewardedAdv.SetActive(true);
        }
        Debug.Log("Watched an ad");
    }

    public void Store() // we go to the in game store
    {
        if (Market != null)
        {
            Market.SetActive(true);
        }
        Debug.Log("Went to the store");
    }

    public void InventoryBag() // we go to the character inventory
    {
        if (Inventory != null)
        {
            Inventory.SetActive(true);
        }
        Debug.Log("Checked my Inventory");
    }

    public void EquipmentRack() // we go to the Character Equipment
    {
        if (Equipment != null)
        {
            Equipment.SetActive(true);
        }
        Debug.Log("Checked my Equipment");
    }

    public void HireChef() // we can buy a permanent buff and ad removal
    {
        if (Chef != null)
        {
            Chef.SetActive(true);
        }
        Debug.Log("Hired an advertiser");
    }

    public void RentBusiness() // Buy temporary buff with in game money
    {
        if (RentMyBusiness != null)
        {
            RentMyBusiness.SetActive(true);
        }
        Debug.Log("Rented a Food Cart");
    }
}
