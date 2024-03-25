using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin1ShiledText : MonoBehaviour
{
    public Text Goblin1ShiledText1;
    int Goblin1Shiled;
    void Start()
    {
        Goblin1ShiledText1 = GetComponent<Text>();
    }


    void Update()
    {
        if (GameManager.Instance.Goblin1CurrentDefense != Goblin1Shiled)
        {
            Goblin1Shiled = GameManager.Instance.Goblin1CurrentDefense;
            Goblin1ShiledText1.text = Goblin1Shiled.ToString();
        }
    }
}
