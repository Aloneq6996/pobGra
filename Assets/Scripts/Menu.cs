using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("mapSelection");
    }
    public void QuitGame()
    { 
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void EasyMode()
    {
        SceneManager.LoadScene("towerDef");
    }
    public void HardMode()
    {
        SceneManager.LoadScene("hard mapa");
    }
    public void FuckGoBack()
    {
        SceneManager.LoadScene("Menu");
    }
}