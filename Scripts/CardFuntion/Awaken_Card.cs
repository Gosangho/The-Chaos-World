using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awaken_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 1;
    public void OnMouseUp()
    {// 2턴간 받는피해가 0이된다.
        if (GameManager.Instance.currentElementalgage >= 3)
        {
            GameManager.Instance.currentElementalgage -= 3;
            GameManager.Instance.AwakenTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.Slime1CurrentAttack = 0;
            GameManager.Instance.Slime2CurrentAttack = 0;
            GameManager.Instance.Slime3CurrentAttack = 0;
            GameManager.Instance.Goblin1CurrentAttack = 0;
            GameManager.Instance.Goblin2CurrentAttack = 0;
            GameManager.Instance.Skeleton1CurrentAttack = 0;
            GameManager.Instance.Skeleton2CurrentAttack = 0;
            GameManager.Instance.stage1_BossCurrentAttack = 0;
            // 고유의 Awaken카드만의 턴 버퍼
            GameManager.Instance.AwakenBool = true;
            // 2턴이 지나면 리셋(Trun스크립트에서)
        }
        Destroy(gameObject);
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
