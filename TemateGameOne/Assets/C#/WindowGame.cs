using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowGame : MonoBehaviour
{
    public GameObject WindowGameOver;

    public void GameOverActivePanel()
    {
        WindowGameOver.SetActive(true);
    }
}
