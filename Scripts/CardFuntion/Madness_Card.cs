using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Madness_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 7;
    public void OnMouseUp()
    {// 10�� ���ظ� ������ ���ݷ��� 2�ϰ� 3 ����Ѵ�.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.MadnessBool = true;
            GameManager.Instance.playerAttackBuff += 3;
            GameManager.Instance.currentElementalgage -= 1; // ������Ż ������ -1
            GameManager.Instance.playerCurrentHp -= 10;
            // 10�� ���ظ� ����
            GameManager.Instance.MadnessTurnBuffer = GameManager.Instance.GameTurn;
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
