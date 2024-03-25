using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameQuit : MonoBehaviour
{
    Button GameQuitButton;
    void Start()
    {
        GameQuitButton = GetComponent<Button>();
        GameQuitButton.onClick.AddListener(GameClose);
    }

    public void GameClose()
    {
        Application.Quit();
    }
}
