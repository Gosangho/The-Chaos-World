using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoarAttack_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 11;
    public void OnMouseUp()
    {// 2�ϰ� ���� ���ݷ��� 3 ��´�.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage -= 1; // ������Ż ������ -1
            GameManager.Instance.RoarAttackTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.Slime1CurrentAttack -= 3;
            GameManager.Instance.Slime2CurrentAttack -= 3;
            GameManager.Instance.Slime3CurrentAttack -= 3;
            GameManager.Instance.Skeleton1CurrentAttack -= 3;
            GameManager.Instance.Skeleton2CurrentAttack -= 3;
            GameManager.Instance.Goblin1CurrentAttack -= 3;
            GameManager.Instance.Goblin2CurrentAttack -= 3;
            GameManager.Instance.stage1_BossCurrentAttack -= 3;

            // �ֳʹ� ���� ������ �߰��Ǹ� ������ ���� ȭ�鿡 ��ġ�� �ٷ� ���� �� �ְ�
            // �ϵ��ڵ��� �����ʰ� ����� ������...
            GameManager.Instance.RoarAttackBool = true;
            Destroy(gameObject); // ������Ʈ ����
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
        {// ��尡 50�� �̻��϶�
            GameManager.Instance.Gold -= 30;
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // ī�并ġ ����Ʈ�� ī�帮��Ʈ[cardnumber]�߰�
            Destroy(gameObject);
        }
    }
}
