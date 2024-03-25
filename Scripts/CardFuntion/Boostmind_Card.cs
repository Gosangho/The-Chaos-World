using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostmind_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 3;
    public void OnMouseUp()
    {// 엘리멘탈 게이지가 2 상승한다.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage += 2;
            // 엘리멘탈 게이지 +2
            if (GameManager.Instance.currentElementalgage >= GameManager.Instance.maxElementalgage)
            {// 엘리멘탈 게이지는 최대 엘리멘탈게이지 수치를 넘을 수 없다.
                GameManager.Instance.currentElementalgage = GameManager.Instance.maxElementalgage;
            }
            Destroy(gameObject); // 오브젝트 삭제
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
