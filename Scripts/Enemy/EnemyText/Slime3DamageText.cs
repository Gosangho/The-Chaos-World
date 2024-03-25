using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime3DamageText : MonoBehaviour
{
    public Text slime3DamageText;
    int slime3Damage;
    void Start()
    {
        slime3DamageText = GetComponent<Text>();
    }


    void Update()
    {
        if (slime3Damage != GameManager.Instance.Slime3CurrentAttack)
        {
            slime3Damage = GameManager.Instance.Slime3CurrentAttack;
            slime3DamageText.text = slime3Damage.ToString();
        }
    }
}
