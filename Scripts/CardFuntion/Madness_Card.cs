using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Madness_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 7;
    public void OnMouseUp()
    {// 10의 피해를 받지만 공격력이 2턴간 3 상승한다.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.MadnessBool = true;
            GameManager.Instance.playerAttackBuff += 3;
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.playerCurrentHp -= 10;
            // 10의 피해를 받음
            GameManager.Instance.MadnessTurnBuffer = GameManager.Instance.GameTurn;
        }
        Destroy(gameObject); // 오브젝트 삭제
    }
    public void OnMouseEnter()
    {
        Cardedge.SetActive(true);
    }

    public void OnMouseExit()
    {
        Cardedge.SetActive(false);
    }
    public void storeCard()
    {
        if (GameManager.Instance.Gold >= 30)
        {// 골드가 50원 이상일때
            GameManager.Instance.Gold -= 30;
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // 카드뭉치 리스트에 카드리스트[cardnumber]추가
            Destroy(gameObject);
        }
    }
}
