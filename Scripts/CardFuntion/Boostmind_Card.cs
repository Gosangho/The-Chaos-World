using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostmind_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 3;
    public void OnMouseUp()
    {// ������Ż �������� 2 ����Ѵ�.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage += 2;
            // ������Ż ������ +2
            if (GameManager.Instance.currentElementalgage >= GameManager.Instance.maxElementalgage)
            {// ������Ż �������� �ִ� ������Ż������ ��ġ�� ���� �� ����.
                GameManager.Instance.currentElementalgage = GameManager.Instance.maxElementalgage;
            }
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
