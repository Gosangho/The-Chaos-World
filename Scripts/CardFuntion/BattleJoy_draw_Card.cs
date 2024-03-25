using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleJoy_draw_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 2;
    public void OnMouseUp()
    {// ī�带 3�� �̴´�.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage += 2;
            // ī�带 1�� �̰�(�̱���)
            GameObject obj = Instantiate(GameManager.Instance.cardGrave[0],
                new Vector3(mousetarget.Instance.targetPos.x,mousetarget.Instance.targetPos.y,0), Quaternion.identity);
            // ī�幫��[0]���� ī�� �ν��Ͻ�
            // ī�幫��[0]��° ī�� ī���ڵ帮��Ʈ�� �߰� -> 
            // ��Ʋ����ī�� ����������
            //
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // ī�� ���������� ������
            GameManager.Instance.cardHand.Remove(GameManager.Instance.cardList[cardNumber]);
            // ī���ڵ忡 �ִ� ��ο�ī�尡 cardHand����Ʈ���� ��������,
            GameManager.Instance.cardHand.Add(GameManager.Instance.cardGrave[0]);
            // ������ ù���� ī�尡 Hand�� �߰��ǰ�
            GameManager.Instance.cardGrave.RemoveAt(0);
            // Hand�� �߰��� ī�尡 �����ӿ��� �����
            GameObject hand = GameObject.Find("Hand");
            if (hand)
            {
                obj.transform.parent = hand.transform;
            }
            GameManager.Instance.createCardHand.Add(obj);
            // ������Ż ������ +2
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
