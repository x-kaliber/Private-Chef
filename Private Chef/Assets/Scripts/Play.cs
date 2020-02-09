using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditGame()
    {
        SceneManager.LoadScene("Credit");
    }

    public void RecipeBook()
    {
        SceneManager.LoadScene("Recipes");
    }

    public void Mall()
    {
        SceneManager.LoadScene("Store");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        Debug.Log ("Quit");
        Application.Quit();
    }
}
