using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilTransform_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 4;
    public void OnMouseUp()
    {// 엘리멘탈 게이지가 666이 되지만 매턴 20의 피해를 받는다.
        if (GameManager.Instance.currentElementalgage >= 5)
        {
            GameManager.Instance.DevilTransform = true; // DevilTransform(Bool) 활성화
            if (GameManager.Instance.DevilTransform)
            {// DevilTransform이 true라면
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
        {// 골드가 50원 이상일때
            GameManager.Instance.Gold -= 30;
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // 카드뭉치 리스트에 카드리스트[cardnumber]추가
            Destroy(gameObject);
        }
    }
}
