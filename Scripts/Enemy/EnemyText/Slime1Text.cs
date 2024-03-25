using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Slime1Text : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Slime1CurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.Slime1CurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
