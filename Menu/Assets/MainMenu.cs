using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //это метод кнопки Run!(Play)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  //GetActiveScene берет индекс уровня, на котором сейчас игрок, и запускает следующий в очереди
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
