using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin1DamageText : MonoBehaviour
{
    public Text goblin1DamageText;
    int goblin1damage;
    void Start()
    {
        goblin1DamageText = GetComponent<Text>();
    }


    void Update()
    {
        if (goblin1damage != GameManager.Instance.Goblin1CurrentAttack)
        {
            goblin1damage = GameManager.Instance.Goblin1CurrentAttack;
            goblin1DamageText.text = goblin1damage.ToString();
        }
    }
}
