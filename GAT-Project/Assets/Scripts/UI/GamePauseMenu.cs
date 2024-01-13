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
        if (Input.GetKeyDown(KeyCode.Escape) && !SettingsMenu.activeSelf) OnPauseGame();
    }

    public void OnPauseGame()
    {
        // Pause Game Actions
        Time.timeScale = Time.timeScale == 1 ? 0 : 1;

        // Toggle UI
        PauseMenu.SetActive(!PauseMenu.activeSelf);

        // Toggle mouse capture/visibility
        if (Cursor.visible) Cursor.lockState = CursorLockMode.None;
        else Cursor.lockState = CursorLockMode.Locked;

        Cursor.visible = !Cursor.visible;

        // Toggle game sound
        AudioListener.pause = !AudioListener.pause;
    }

    public void OnClickQuitToMenu()
    {
        SceneManager.LoadScene("GAT_StartMenu");
    }

    public void OnClickQuitToDesktop()
    {
        Application.Quit();
    }
}
