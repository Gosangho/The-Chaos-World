using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goblin2Text : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Goblin2CurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.Goblin2CurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
