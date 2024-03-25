using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin2DamageText : MonoBehaviour
{
    public Text goblin2DamageText;
    int goblin2damage;
    void Start()
    {
        goblin2DamageText = GetComponent<Text>();
    }


    void Update()
    {
        if (goblin2damage != GameManager.Instance.Goblin2CurrentAttack)
        {
            goblin2damage = GameManager.Instance.Goblin2CurrentAttack;
            goblin2DamageText.text = goblin2damage.ToString();
        }
    }
}
