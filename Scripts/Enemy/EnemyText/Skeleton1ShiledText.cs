using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skeleton1ShiledText : MonoBehaviour
{
    public Text Skeleton1ShiledText1;
    int Skeleton1Shiled;
    void Start()
    {
        Skeleton1ShiledText1 = GetComponent<Text>();
    }

    
    void Update()
    {
        if (GameManager.Instance.Skeleton1CurrentDefense!=Skeleton1Shiled)
        {
            Skeleton1Shiled = GameManager.Instance.Skeleton1CurrentDefense;
            Skeleton1ShiledText1.text = Skeleton1Shiled.ToString();
        }
    }
}
