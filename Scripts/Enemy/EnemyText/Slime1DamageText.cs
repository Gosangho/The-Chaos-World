using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slime1DamageText : MonoBehaviour
{
    public Text slime1DamageText;
    int slime1Damage;
    void Start()
    {
        slime1DamageText = GetComponent<Text>();
    }

    
    void Update()
    {
        if (slime1Damage!=GameManager.Instance.Slime1CurrentAttack)
        {
            slime1Damage = GameManager.Instance.Slime1CurrentAttack;
            slime1DamageText.text = slime1Damage.ToString();
        }
    }
}
