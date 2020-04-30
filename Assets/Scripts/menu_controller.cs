using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour
{
    public GameObject inGameUI;
    public GameObject menu;
    public void PlayGame()
    {
        global_variable.isPause = false;
        inGameUI.SetActive(true);
        Time.timeScale = 1;
        menu.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void PauseGame()
    {
        global_variable.isPause = true;
        Time.timeScale = 0;
        inGameUI.SetActive(false);
        menu.SetActive(true);
    }
    public void Start()
    {
        PauseGame();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        } 
    }
}
