using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolve_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 10;
    public void OnMouseUp()
    {// 1턴간 공격력이 2 상승한다.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.ResolveTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.playerAttackBuff += 2;
            GameManager.Instance.ResolveBool = true;
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
