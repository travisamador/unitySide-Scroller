using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
    public void RestartGame()
    {
        //2 ways to reload gameplay scene
        //SceneManager.LoadScene("GamePlay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
