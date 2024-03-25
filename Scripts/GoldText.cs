using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GoldText : MonoBehaviour
{
    TextMeshProUGUI GoldTexts;
    int goldint;
    void Start()
    {
        GoldTexts = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        if (GameManager.Instance.Gold != goldint)
        {
            goldint = GameManager.Instance.Gold;
            GoldTexts.text = goldint.ToString();
        }
    }
}
