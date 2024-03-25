using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleJoy_draw_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 2;
    public void OnMouseUp()
    {// 카드를 3장 뽑는다.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage += 2;
            // 카드를 1장 뽑고(미구현)
            GameObject obj = Instantiate(GameManager.Instance.cardGrave[0],
                new Vector3(mousetarget.Instance.targetPos.x,mousetarget.Instance.targetPos.y,0), Quaternion.identity);
            // 카드무덤[0]번쨰 카드 인스턴스
            // 카드무덤[0]번째 카드 카드핸드리스트에 추가 -> 
            // 배틀조이카드 무덤속으로
            //
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // 카드 무덤속으로 들어가야함
            GameManager.Instance.cardHand.Remove(GameManager.Instance.cardList[cardNumber]);
            // 카드핸드에 있는 드로우카드가 cardHand리스트에서 지워지고,
            GameManager.Instance.cardHand.Add(GameManager.Instance.cardGrave[0]);
            // 무덤속 첫번쨰 카드가 Hand에 추가되고
            GameManager.Instance.cardGrave.RemoveAt(0);
            // Hand에 추가된 카드가 무덤속에서 사라짐
            GameObject hand = GameObject.Find("Hand");
            if (hand)
            {
                obj.transform.parent = hand.transform;
            }
            GameManager.Instance.createCardHand.Add(obj);
            // 엘리멘탈 게이지 +2
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
