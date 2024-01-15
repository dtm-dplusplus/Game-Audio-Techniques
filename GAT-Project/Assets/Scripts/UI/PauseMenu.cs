using UnityEngine;
using Cinemachine;

public class PauseMenu : MonoBehaviour
{
    public GameObject SettingsMenu;

    // We use this to pause camera movement
    public CinemachineBrain CineBrain;

    private void Start()
    {
        if (SettingsMenu == null)
            SettingsMenu = GameObject.FindGameObjectWithTag("SettingsMenu");

        if(CineBrain == null)
            CineBrain = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CinemachineBrain>();

        gameObject.SetActive(false);
        SettingsMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SettingsMenu.activeSelf) SettingsMenu.SetActive(false);
            else gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        // Pause Game Actions
        Time.timeScale = 0;
        CineBrain.enabled = false;

        // Toggle mouse capture + visibility
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        // Toggle game sound
        AudioListener.pause = true;
    }

    private void OnDisable()
    {
        // Pause Game Actions
        Time.timeScale = 1;
        CineBrain.enabled = true;

        // Toggle mouse capture + visibility
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Toggle game sound
        AudioListener.pause = false;
    }
}
