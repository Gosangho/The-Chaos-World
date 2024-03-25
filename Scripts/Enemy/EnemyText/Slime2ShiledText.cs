using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime2ShiledText : MonoBehaviour
{
    public Text Slime2Shield;
    int Slime2Defense;
    void Start()
    {
        Slime2Shield = GetComponent<Text>();
    }


    void Update()
    {
        if (GameManager.Instance.Slime2CurrentDefense != Slime2Defense)
        {
            Slime2Defense = GameManager.Instance.Slime2CurrentDefense;
            Slime2Shield.text = Slime2Defense.ToString();
        }
    }
}
