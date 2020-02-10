using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

  public void PlayGame() // We call the main Game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditGame() // We call the Credit Scene
    {
        SceneManager.LoadScene("Credit");
    }

    public void RecipeBook() // We call the Recipe Book Scene
    {
        SceneManager.LoadScene("Recipes");
    }

    public void Mall() // We call the Store/Mall scene
    {
        SceneManager.LoadScene("Store");
    }

    public void OptionsMenu() // We call Options Menu Scene
    {
        SceneManager.LoadScene("Options");
    }

    public void Office() // We call Office Scene
    {
        SceneManager.LoadScene("Office");
    }

    public void QuitGame() // We Quit the game
    {
        Debug.Log ("Quit");
        Application.Quit();
    }
}
