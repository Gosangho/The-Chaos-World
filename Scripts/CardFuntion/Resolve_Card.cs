using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolve_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 10;
    public void OnMouseUp()
    {// 1�ϰ� ���ݷ��� 2 ����Ѵ�.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage -= 1; // ������Ż ������ -1
            GameManager.Instance.ResolveTurnBuffer = GameManager.Instance.GameTurn;
            GameManager.Instance.playerAttackBuff += 2;
            GameManager.Instance.ResolveBool = true;
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
