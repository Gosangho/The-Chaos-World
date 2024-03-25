using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skeleton2DamageText : MonoBehaviour
{
    public Text skeleton2DamageText;
    int skeleton2Damage;
    void Start()
    {
        skeleton2DamageText = GetComponent<Text>();
    }


    void Update()
    {
        if (skeleton2Damage != GameManager.Instance.Skeleton2CurrentAttack)
        {
            skeleton2Damage = GameManager.Instance.Skeleton2CurrentAttack;
            skeleton2DamageText.text = skeleton2Damage.ToString();
        }
    }
}
