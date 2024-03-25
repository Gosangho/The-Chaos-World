using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDefenseText : MonoBehaviour
{
    public Text PlayerDefenseText1;
    int PlayerDefenseBuff;
    void Start()
    {
        PlayerDefenseText1 = GetComponent<Text>();
    }

    
    void Update()
    {
        if (GameManager.Instance.playerDefenseBuff!=PlayerDefenseBuff)
        {
            PlayerDefenseBuff = GameManager.Instance.playerDefenseBuff;
            PlayerDefenseText1.text = PlayerDefenseBuff.ToString();
        }
    }
}
