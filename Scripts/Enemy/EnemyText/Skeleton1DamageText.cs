using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skeleton1DamageText : MonoBehaviour
{
    public Text skeleton1DamageText;
    int skeleton1Damage;
    void Start()
    {
        skeleton1DamageText = GetComponent<Text>();
    }


    void Update()
    {
        if (skeleton1Damage != GameManager.Instance.Skeleton1CurrentAttack)
        {
            skeleton1Damage = GameManager.Instance.Skeleton1CurrentAttack;
            skeleton1DamageText.text = skeleton1Damage.ToString();
        }
    }
}
