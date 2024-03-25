using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Slime3Text : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Slime3CurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.Slime3CurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
