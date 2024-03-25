using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Ability : MonoBehaviour
{
    TextMeshProUGUI abilitytext;
    int abil;
    void Start()
    {
        abilitytext = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.currentElementalgage != abil)
        {
            abil = GameManager.Instance.currentElementalgage;
            abilitytext.text = abil.ToString();
        }
    }
}
