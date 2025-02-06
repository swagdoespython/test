using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Load Scene
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("The Player has selected Play Game");
    }
    public void Setting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("The Player has selected Settings");
    }
    public void Characters()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Debug.Log("The Player has selected Characters");
    }
    public void Progress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        Debug.Log("The Player has selected Progress");
    }

    //Quit Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("The Player has Quit the game");
    }
}