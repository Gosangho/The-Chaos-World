using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBreak_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 15;

    private void OnMouseUp()
    {// 2턴간 적의 공격력을 3 감소시킨다.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage -= 1;
            GameManager.Instance.WeaponBreakTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.Slime1CurrentAttack -= 3;
            GameManager.Instance.Slime2CurrentAttack -= 3;
            GameManager.Instance.Slime3CurrentAttack -= 3;
            GameManager.Instance.Skeleton1CurrentAttack -= 3;
            GameManager.Instance.Skeleton2CurrentAttack -= 3;
            GameManager.Instance.Goblin1CurrentAttack -= 3;
            GameManager.Instance.Goblin2CurrentAttack -= 3;
            GameManager.Instance.stage1_BossCurrentAttack -= 3;
            GameManager.Instance.WeaponBool = true;
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
