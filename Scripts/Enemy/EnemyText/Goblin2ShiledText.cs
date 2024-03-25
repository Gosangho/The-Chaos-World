using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin2ShiledText : MonoBehaviour
{
    public Text Goblin2ShiledText1;
    int Goblin2Shiled;
    void Start()
    {
        Goblin2ShiledText1 = GetComponent<Text>();
    }


    void Update()
    {
        if (GameManager.Instance.Goblin2CurrentDefense != Goblin2Shiled)
        {
            Goblin2Shiled = GameManager.Instance.Goblin2CurrentDefense;
            Goblin2ShiledText1.text = Goblin2Shiled.ToString();
        }
    }
}
