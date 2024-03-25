using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class slime2Text : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Slime2CurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.Slime2CurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
