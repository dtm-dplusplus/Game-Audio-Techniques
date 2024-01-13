using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("UIManager")]
    [Tooltip("Should mouse be visible on start")]
    public bool MouseStartVisible = true;
    [Tooltip("SettingsMenu")]
    public GameObject SettingsMenu = null;

    private void Awake()
    {
       if (SettingsMenu == null)
            SettingsMenu = GameObject.FindGameObjectWithTag("SettingsMenu");
    }

    private void Start()
    {
        if (MouseStartVisible)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}