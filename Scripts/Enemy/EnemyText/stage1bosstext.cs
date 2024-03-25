using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class stage1bosstext : MonoBehaviour
{
    TextMeshProUGUI enemyhptext;
    int enemyhptextint;
    void Start()
    {
        enemyhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.stage1_BossCurrentHp != enemyhptextint)
        {
            enemyhptextint = GameManager.Instance.stage1_BossCurrentHp;
            enemyhptext.text = enemyhptextint.ToString();
        }
    }
}
