using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttackBuffText : MonoBehaviour
{
    public Text PlayerAttackBuffText1;
    int PlayerAttackBuffs;
    void Start()
    {
        PlayerAttackBuffText1 = GetComponent<Text>();
    }

    
    void Update()
    {
        if (GameManager.Instance.playerAttackBuff!=PlayerAttackBuffs)
        {
            PlayerAttackBuffs = GameManager.Instance.playerAttackBuff;
            PlayerAttackBuffText1.text = PlayerAttackBuffs.ToString();
        }
    }
}
