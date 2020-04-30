using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class In_game_ui_controller : MonoBehaviour
{

    public GameObject ingame_menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowMenu()
    {
        global_variable.isPause = true;
        ingame_menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayAgain()
    {
        // initialization
        global_variable.speed = 35f;
        global_variable.live = 2;
        global_variable.isshield = false;
        global_variable.getcoins = 0;
        global_variable.score = 0;
        global_variable.isPause = false;
        SceneManager.LoadScene("PlayAgain");
    }

    public void Quit()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update()
    {
        if (global_variable.live <= 0)
        {
            ShowMenu();
        }
    }
}
