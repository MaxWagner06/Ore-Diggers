using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject InventoryPanel;
    public GameObject PauseMenu;
    public bool Inventory_Open = false;
    public bool PauseMenu_Open = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Inventory_Open)
            {
                InventoryPanel.SetActive(false);
                Inventory_Open = false;
            }
            else
            {
                InventoryPanel.SetActive(true);
                Inventory_Open = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Inventory_Open)
            {
                if (!PauseMenu_Open)
                {
                    PauseMenu.SetActive(true);
                    PauseMenu_Open = true;
                    Time.timeScale = 0;
                }
                else
                {
                    PauseMenu.SetActive(false);
                    PauseMenu_Open = false;
                    Time.timeScale = 1;
                }
            }
        }
    }
    public void BackButtonI()
    {
        InventoryPanel.SetActive(false);
        Inventory_Open = false;
    }
    public void ResumeButton()
    {
        PauseMenu.SetActive(false);
        PauseMenu_Open = false;
        Time.timeScale = 1;
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
