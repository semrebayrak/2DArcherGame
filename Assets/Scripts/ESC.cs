using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ESC : MonoBehaviour
{


    public static bool GameIspaused = false;
    public GameObject pauseMenuUI;
    int temp = 0;
   
    // Start is called before the first frame update
    void Start()
    {

        if (SceneManager.GetActiveScene().name == "Game")
        {
            pauseMenuUI.SetActive(false);
            Resume();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIspaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
    }


    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIspaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIspaused = true;
    }

    public void Quit()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
}
