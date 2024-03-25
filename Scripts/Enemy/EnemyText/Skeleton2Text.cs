using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Skeleton2Text : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Skeleton2CurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.Skeleton2CurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
