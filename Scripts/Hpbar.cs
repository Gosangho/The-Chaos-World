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
        {// ���� �ٸ���쿡�� �۵��ϰԲ� ����
            hp = GameManager.Instance.playerCurrentHp;
            playerhptext.text = hp.ToString();
        }
    }
}
