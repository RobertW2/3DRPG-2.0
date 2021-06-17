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
        SceneManager.LoadScene("MainMenuScene");
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
        SceneManager.LoadScene("StatSelector");
    }

    public void KeyBidnings()
    {
        SceneManager.LoadScene("KeyBinding");
    }

    public static void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif
    }

    public void Reset()
    {
        SceneManager.LoadScene("playground");
    }
}
