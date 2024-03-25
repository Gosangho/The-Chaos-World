using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Skeleton1Text : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Skeleton1CurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.Skeleton1CurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
