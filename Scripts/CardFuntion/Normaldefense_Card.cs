using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normaldefense_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 10;
    public void OnMouseUp()
    {// 적의 공격을 5만큼 막는다.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.playerDefenseBuff += 5;
            GameManager.Instance.NormalDefenseBool = true;
            Destroy(gameObject); // 오브젝트 삭제
        }
    }
    public void OnMouseEnter()
    {
        Cardedge.SetActive(true);
    }

    public void OnMouseExit()
    {
        Cardedge.SetActive(false);
    }
    
}
