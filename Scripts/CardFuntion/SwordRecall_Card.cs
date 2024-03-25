using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRecall_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 14;
    public void OnMouseUp()
    {// 2턴간 플레이어의 어택버프를 15상승
        if (GameManager.Instance.currentElementalgage >= 3)
        {
            GameManager.Instance.currentElementalgage -= 3;
            GameManager.Instance.SwordRecallTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.playerAttackBuff += 15;
            GameManager.Instance.SwordRecallBool = true;
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
