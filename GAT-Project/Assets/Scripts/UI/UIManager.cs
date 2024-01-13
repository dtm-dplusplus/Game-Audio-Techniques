using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("UIManager")]
    [Tooltip("SettingsMenu")]
    public GameObject SettingsMenu = null;

    private void Awake()
    {
       if (SettingsMenu == null)
            SettingsMenu = GameObject.FindGameObjectWithTag("SettingsMenu");
    }

    private void Start()
    {
    }

  
}