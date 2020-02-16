using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarketManager : MonoBehaviour
{
    public void HiringAgency() // We call the Hiring Agency scene
    {
        SceneManager.LoadScene("HiringAgency");
    }
    public void Office() // We call the Office Scene
    {
        SceneManager.LoadScene("Office");
    }
    public void GroceryStore() // We call the Grocery store Scene
    {
        SceneManager.LoadScene("GroceryStore");
    }
    public void HomeB() // We call the Main Menu scene
    {
        SceneManager.LoadScene(0);
    }
}
