using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilTransform_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 4;
    public void OnMouseUp()
    {// ������Ż �������� 666�� ������ ���� 20�� ���ظ� �޴´�.
        if (GameManager.Instance.currentElementalgage >= 5)
        {
            GameManager.Instance.DevilTransform = true; // DevilTransform(Bool) Ȱ��ȭ
            if (GameManager.Instance.DevilTransform)
            {// DevilTransform�� true���
                GameManager.Instance.currentElementalgage = 666;
            }
            Destroy(gameObject);
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
