using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauseMenu : MonoBehaviour
{
    GameObject PauseMenu;
    GameObject SettingsMenu;

    private void Start()
    {
        if (PauseMenu == null)
            PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");

        if (SettingsMenu == null)
            SettingsMenu = GameObject.FindGameObjectWithTag("SettingsMenu");

        PauseMenu.SetActive(false);
        SettingsMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) OnPauseGame();
    }

    public void OnPauseGame()
    {
        PauseMenu.SetActive(!PauseMenu.activeSelf);

        Debug.Log(Time.timeScale);
        if (Time.timeScale == 1) Time.timeScale = 0;
        else Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        AudioListener.pause = !AudioListener.pause;
    }

    public void OnClickInGameSettings()
    {
        SettingsMenu.SetActive(true);
    }

    public void OnClickQuitToMenu()
    {
        SceneManager.LoadScene("GAT_StartMenu");
    }

    public void onClickQuitToDesktop()
    {
        Application.Quit();
    }
}
