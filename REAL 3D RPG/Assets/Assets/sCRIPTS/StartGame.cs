using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void BeginGame() // Opens Start Game option in main menu
    {
        SceneManager.LoadScene("StartGame");
    }

    public void OpenOptions() // Opens Options Menu in Main Menu
    {
        SceneManager.LoadScene("Options");
    }

    public void Back() // Goes Back to start of main menu
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Graphics() // Opens Graphics Settings
    {
        SceneManager.LoadScene("GraphicsSettings");
    }

    public void Audio() // Opens Audio Settings
    {
        SceneManager.LoadScene("Audio");
    }

    public void Newgame()
    {
        SceneManager.LoadScene("playground");
    }
}
