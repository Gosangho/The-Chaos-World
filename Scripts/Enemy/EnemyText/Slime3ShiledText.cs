using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime3ShiledText : MonoBehaviour
{
    public Text Slime3Shield;
    int Slime3Defense;
    void Start()
    {
        Slime3Shield = GetComponent<Text>();
    }


    void Update()
    {
        if (GameManager.Instance.Slime3CurrentDefense != Slime3Defense)
        {
            Slime3Defense = GameManager.Instance.Slime3CurrentDefense;
            Slime3Shield.text = Slime3Defense.ToString();
        }
    }
}
