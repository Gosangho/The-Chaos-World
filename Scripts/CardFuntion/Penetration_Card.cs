using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penetration_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 9;
    public void OnMouseUp()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage-=1; // ������Ż ������ -1
            GameManager.Instance.PenetrationBool = true;
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
