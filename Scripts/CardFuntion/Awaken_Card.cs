using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awaken_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 1;
    public void OnMouseUp()
    {// 2�ϰ� �޴����ذ� 0�̵ȴ�.
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
            // ������ Awakenī�常�� �� ����
            GameManager.Instance.AwakenBool = true;
            // 2���� ������ ����(Trun��ũ��Ʈ����)
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
        {// ��尡 50�� �̻��϶�
            GameManager.Instance.Gold -= 30;
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // ī�并ġ ����Ʈ�� ī�帮��Ʈ[cardnumber]�߰�
            Destroy(gameObject);
        }
    }
}
