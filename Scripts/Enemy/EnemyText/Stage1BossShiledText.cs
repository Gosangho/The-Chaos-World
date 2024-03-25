using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1BossShiledText : MonoBehaviour
{
    public Text Stage1BossShiledText1;
    int Stage1BossShiled;
    void Start()
    {
        Stage1BossShiledText1 = GetComponent<Text>();
    }


    void Update()
    {
        if (GameManager.Instance.stage1_BossCurrentDefense != Stage1BossShiled)
        {
            Stage1BossShiled = GameManager.Instance.stage1_BossCurrentDefense;
            Stage1BossShiledText1.text = Stage1BossShiled.ToString();
        }
    }
}
