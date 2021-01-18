using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void Playgame()
    {
        SceneManager.LoadScene("gamesearch");
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void Shop()
    {
        SceneManager.LoadScene("shop");
    }
}
