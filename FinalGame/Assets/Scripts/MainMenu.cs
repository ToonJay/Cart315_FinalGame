using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Awake()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();
    }
    public void Menu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.ExitPlaymode();
    }
}
