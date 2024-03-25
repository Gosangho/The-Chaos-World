using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class Hpbar : MonoBehaviour
{
    TextMeshProUGUI playerhptext;
    int hp;
    void Start()
    {
        playerhptext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.playerCurrentHp != hp)
        {// 값이 다를경우에만 작동하게끔 해줌
            hp = GameManager.Instance.playerCurrentHp;
            playerhptext.text = hp.ToString();
        }
    }
}
