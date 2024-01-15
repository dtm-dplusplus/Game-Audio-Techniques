using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePauseMenu : MonoBehaviour
{
    public GameObject PauseMenu;

    private void Start()
    {
        if (PauseMenu == null)
            PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !PauseMenu.activeSelf) 
            PauseMenu.SetActive(true);
    }
}
