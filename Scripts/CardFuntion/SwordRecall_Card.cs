using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRecall_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 14;
    public void OnMouseUp()
    {// 2�ϰ� �÷��̾��� ���ù����� 15���
        if (GameManager.Instance.currentElementalgage >= 3)
        {
            GameManager.Instance.currentElementalgage -= 3;
            GameManager.Instance.SwordRecallTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.playerAttackBuff += 15;
            GameManager.Instance.SwordRecallBool = true;
        }
        Destroy(gameObject); // ������Ʈ ����
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
