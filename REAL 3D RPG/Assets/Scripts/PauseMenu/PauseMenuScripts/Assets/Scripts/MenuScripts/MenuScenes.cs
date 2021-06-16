using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScenes : MonoBehaviour
{
    public GameObject MainMenuState;
    public GameObject settingsMenu;
    public void PlayButton()
    {
        SceneManager.LoadScene("_SCENE_");
    }

   
    public void QuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void SettingMenutoggleON()
    {
        MainMenuState.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void SettingsMenutoggleOff()
    {
        MainMenuState.SetActive(true);
        settingsMenu.SetActive(false);
    }
}
