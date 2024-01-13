using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    GameObject SettingsMenu;

    private void Start()
    {
       SettingsMenu = GameObject.FindGameObjectWithTag("SettingsMenu");
    }

    public void OnClickPlayGame()
    {
        SceneManager.LoadScene("GAT_Scene");
    }

    public void OnClickSettings()
    {
        if(SettingsMenu) SettingsMenu.SetActive(true);
    } 

    public void OnQuitGameToDesktop()
    {
        Application.Quit();
    }
}
