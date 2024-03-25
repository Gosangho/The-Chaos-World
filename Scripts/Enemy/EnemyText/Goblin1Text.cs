using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goblin1Text : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Goblin1CurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.Goblin1CurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
