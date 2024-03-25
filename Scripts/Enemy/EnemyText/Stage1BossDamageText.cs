using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1BossDamageText : MonoBehaviour
{
    public Text stage1BossDamageText;
    int stage1BossDamage;
    void Start()
    {
        stage1BossDamageText = GetComponent<Text>();
    }


    void Update()
    {
        if (stage1BossDamage != GameManager.Instance.stage1_BossCurrentAttack)
        {
            stage1BossDamage = GameManager.Instance.stage1_BossCurrentAttack;
            stage1BossDamageText.text = stage1BossDamage.ToString();
        }
    }
}
