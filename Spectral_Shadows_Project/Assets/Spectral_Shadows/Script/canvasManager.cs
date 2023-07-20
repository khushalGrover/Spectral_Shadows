using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
    public static canvasManager instance;

    // [Header("_______Joysticks________")]
    // [Tooltip("Joysticks")]
    // public Joystick leftJoystick;
    // public Joystick rightJoystick;

    [Header("______Canvas_____")]
    [Tooltip("Canvas")]
    public GameObject pauseCanvas;
    public GameObject optionCanvas;
   


    private void Start()
    {
        // if(SceneManager.GetActiveScene().buildIndex == 1)
        // {
        //     DeActivateAllCanvas();
        // }

        Time.timeScale = 1;
    }

    void DeActivateAllCanvas()
    {
        
    }

    public void loadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void loadFirstScene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("trying to load");
    }
    public void loadSecondScene()
    {
        SceneManager.LoadScene(2);
    }
    public void APPQUIT()
    {
        Application.Quit();
    }

    public void pauseGame()
    {
        // activate AND deactive screen 
        pauseCanvas.SetActive(true);
    
        // pause/slow game
        Time.timeScale = 0.05f;

    }

    public void gameOver()
    {
        

        pauseCanvas.SetActive(false);

        Time.timeScale = 0f;

    }

    public void resumeGame()
    {
        // Depactivate AND active Screen
        pauseCanvas.SetActive(false);
     
        // resume game
        Time.timeScale = 1;

    }

    public void option()
    {
        DeActivateAllCanvas();
        optionCanvas.SetActive(true);
        Debug.Log("Option button press");
    }

    public void Restart()
    {
        // reload current screen and deacivate all canvas...
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}