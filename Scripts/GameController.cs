using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject LevelPanel;
    public GameObject ControlsPanel;
    public GameObject MainText;
    public GameObject Player;
    public GameObject PauseMenu;

    private void Start()
    {
        ControlsPanel.SetActive(false);
        LevelPanel.SetActive(false);
        MainText.SetActive(true);
        PauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        PauseMenu.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Start");
    }

    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LevelPanelActive()
    {
        LevelPanel.SetActive(true);
        MainText.SetActive(false);
    }
    public void ControlsPanelActive()
    {
        ControlsPanel.SetActive(true);
        MainText.SetActive(false);
    }
    public void LevelStart1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LevelStart2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LevelStart3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void LevelStart4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void MainTextActive()
    {
        LevelPanel.SetActive(false);
        ControlsPanel.SetActive(false);
        MainText.SetActive(true);
    }
}
