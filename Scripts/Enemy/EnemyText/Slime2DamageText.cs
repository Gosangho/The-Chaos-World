using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime2DamageText : MonoBehaviour
{
    public Text slime2DamageText;
    int slime2Damage;
    void Start()
    {
        slime2DamageText = GetComponent<Text>();
    }


    void Update()
    {
        if (slime2Damage != GameManager.Instance.Slime2CurrentAttack)
        {
            slime2Damage = GameManager.Instance.Slime2CurrentAttack;
            slime2DamageText.text = slime2Damage.ToString();
        }
    }
}
