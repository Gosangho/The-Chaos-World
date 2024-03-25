using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slime1ShieldText : MonoBehaviour
{
    public Text Slime1Shield;
    int Slime1Defense;
    void Start()
    {
        Slime1Shield = GetComponent<Text>();
    }

    
    void Update()
    {
        if (GameManager.Instance.Slime1CurrentDefense!=Slime1Defense)
        {
            Slime1Defense = GameManager.Instance.Slime1CurrentDefense;
            Slime1Shield.text = Slime1Defense.ToString();
        }
    }
}
