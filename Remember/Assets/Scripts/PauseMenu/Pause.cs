using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject panelPause;
    
    public Button buttonPause;
    public Button buttonReturn;
    public Button buttonMenu;

    void Start()
    {
        panelPause.SetActive(false);

        buttonPause = GetComponent<Button>();
        buttonPause.onClick.AddListener(PausePanel);

        buttonReturn = GetComponent<Button>();
        buttonReturn.onClick.AddListener(ReturnGame);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelPause.SetActive(true);
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            panelPause.SetActive(false); ;
            Time.timeScale = 1;
        }
    }

    public void PausePanel()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0;
    }

    public void ReturnGame()
    {
        panelPause.SetActive(false); ;
        Time.timeScale = 1;
    }

    public void MenuReturn()
    {
        SceneManager.LoadScene(0);
    }
}
