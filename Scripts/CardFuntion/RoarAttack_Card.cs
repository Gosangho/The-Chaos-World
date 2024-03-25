using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoarAttack_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 11;
    public void OnMouseUp()
    {// 2턴간 적의 공격력을 3 깎는다.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.RoarAttackTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.Slime1CurrentAttack -= 3;
            GameManager.Instance.Slime2CurrentAttack -= 3;
            GameManager.Instance.Slime3CurrentAttack -= 3;
            GameManager.Instance.Skeleton1CurrentAttack -= 3;
            GameManager.Instance.Skeleton2CurrentAttack -= 3;
            GameManager.Instance.Goblin1CurrentAttack -= 3;
            GameManager.Instance.Goblin2CurrentAttack -= 3;
            GameManager.Instance.stage1_BossCurrentAttack -= 3;

            // 애너미 어택 너프가 추가되면 누르는 순간 화면에 수치가 바로 보일 수 있게
            // 하드코딩을 하지않고 방법이 없을까...
            GameManager.Instance.RoarAttackBool = true;
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
