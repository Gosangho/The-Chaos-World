using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckLeap_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 6;
    public void OnMouseUp()
    {// 엘리멘탈 게이지를 1 회복하고 체력을 3 회복한다.
        GameManager.Instance.currentElementalgage += 1;
        if (GameManager.Instance.currentElementalgage >= GameManager.Instance.maxElementalgage)
        {// 예외설정
            GameManager.Instance.currentElementalgage = GameManager.Instance.maxElementalgage;
        }
        GameManager.Instance.playerCurrentHp += 3;
        if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
        {// 예외설정
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
        {// 골드가 50원 이상일때
            GameManager.Instance.Gold -= 30;
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // 카드뭉치 리스트에 카드리스트[cardnumber]추가
            Destroy(gameObject);
        }
    }
}
