using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skeleton2ShiledText : MonoBehaviour
{
    public Text Skeleton2ShiledText1;
    int Skeleton2Shiled;
    void Start()
    {
        Skeleton2ShiledText1 = GetComponent<Text>();
    }


    void Update()
    {
        if (GameManager.Instance.Skeleton2CurrentDefense != Skeleton2Shiled)
        {
            Skeleton2Shiled = GameManager.Instance.Skeleton2CurrentDefense;
            Skeleton2ShiledText1.text = Skeleton2Shiled.ToString();
        }
    }
}
