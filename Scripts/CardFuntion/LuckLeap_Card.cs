using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckLeap_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 6;
    public void OnMouseUp()
    {// ������Ż �������� 1 ȸ���ϰ� ü���� 3 ȸ���Ѵ�.
        GameManager.Instance.currentElementalgage += 1;
        if (GameManager.Instance.currentElementalgage >= GameManager.Instance.maxElementalgage)
        {// ���ܼ���
            GameManager.Instance.currentElementalgage = GameManager.Instance.maxElementalgage;
        }
        GameManager.Instance.playerCurrentHp += 3;
        if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
        {// ���ܼ���
            GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
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
