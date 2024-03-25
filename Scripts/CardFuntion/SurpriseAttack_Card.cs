using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurpriseAttack_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 13;

    private void Update()
    {
        if (mousetarget.Instance.surpriseAttackBool)
        {
            switch (mousetarget.Instance.monster)
            {
                case MONSTER.SLIME1:
                    Slime1SurpriseAttack();
                    Debug.Log("switchSlime1SurpriseAttack");
                    break;
                case MONSTER.SLIME2:
                    Slime2SurpriseAttack();
                    Debug.Log("switchSlime2SurpriseAttack");
                    break;
                case MONSTER.SLIME3:
                    Slime3SurpriseAttack();
                    Debug.Log("switchSlime3SurpriseAttack");
                    break;
                case MONSTER.STAGE1BOSS:
                    stage1BossSurpriseAttack();
                    Debug.Log("switchBossSurpriseAttack");
                    break;
                case MONSTER.GOBLIN1:
                    Goblin1SurpriseAttack();
                    Debug.Log("switchGoblin1SurpriseAttack");
                    break;
                case MONSTER.GOBLIN2:
                    Goblin2SurpriseAttack();
                    Debug.Log("switchGoblin2SurpriseAttack");
                    break;
                case MONSTER.SKELETON1:
                    Skeleton1SurpriseAttack();
                    Debug.Log("switchskeleton1SurpriseAttack");
                    break;
                case MONSTER.SKELETON2:
                    Skeleton2SurpriseAttack();
                    Debug.Log("switchskeleton2SurpriseAttack");
                    break;
                default:
                    Debug.Log("switchdefault");
                    break;
            }
        }
    }
    void Slime1SurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime1.Slime1Anim.SetTrigger("Slime1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.Slime1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime1CurrentDefense = 0;
            }
            GameManager.Instance.Slime1CurrentHp -= (GameManager.Instance.playerAttackBuff + 8)
                - GameManager.Instance.Slime1CurrentDefense;
            cardDraw3();
            // 카드 드로우
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime2SurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime2.Slime2Anim.SetTrigger("Slime2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.Slime2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime2CurrentDefense = 0;
            }
            GameManager.Instance.Slime2CurrentHp -= (GameManager.Instance.playerAttackBuff + 8)
                - GameManager.Instance.Slime2CurrentDefense;
            cardDraw3();
            // 카드 드로우

            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime3SurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime3.Slime3Anim.SetTrigger("Slime3_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.Slime3CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime3CurrentDefense = 0;
            }
            GameManager.Instance.Slime3CurrentHp -= (GameManager.Instance.playerAttackBuff + 8)
                - GameManager.Instance.Slime3CurrentDefense;
            cardDraw3();
            // 카드 드로우

            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void stage1BossSurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.stage1_BossCurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.stage1_BossCurrentDefense = 0;
            }
            GameManager.Instance.stage1_BossCurrentHp -= (GameManager.Instance.playerAttackBuff + 8)
                - GameManager.Instance.stage1_BossCurrentDefense;
            cardDraw3();
            // 카드 드로우

            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin1SurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin1.Goblin1Anim.SetTrigger("Goblin1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.Goblin1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Goblin1CurrentDefense = 0;
            }
            GameManager.Instance.Goblin1CurrentHp -= (GameManager.Instance.playerAttackBuff + 8)
                - GameManager.Instance.Goblin1CurrentDefense;
            cardDraw3();
            // 카드 드로우

            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin2SurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin2.Goblin2Anim.SetTrigger("Goblin2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.Goblin2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Goblin2CurrentDefense = 0;
            }
            GameManager.Instance.Goblin2CurrentHp -= (GameManager.Instance.playerAttackBuff +8)
                - GameManager.Instance.Goblin2CurrentDefense;
            cardDraw3();

            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton1SurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.Skeleton1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Skeleton1CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton1CurrentHp -= (GameManager.Instance.playerAttackBuff + 8)
                - GameManager.Instance.Skeleton1CurrentDefense;
            cardDraw3();

            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton2SurpriseAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            if (GameManager.Instance.Skeleton2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Skeleton2CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton2CurrentHp -= (GameManager.Instance.playerAttackBuff + 8)
                - GameManager.Instance.Skeleton2CurrentDefense;
            cardDraw3();

            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.surpriseAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }

    void cardDraw3()
    {
        Debug.Log("서프라이즈 카드드로우");
        GameObject obj = Instantiate(GameManager.Instance.cardGrave[0],
                new Vector3(mousetarget.Instance.firstTargetPos.x, mousetarget.Instance.firstTargetPos.y, 0), Quaternion.identity);
        // 카드무덤[0]번쨰 카드 인스턴스
        // 카드무덤[0]번째 카드 카드핸드리스트에 추가 -> 
        // 배틀조이카드 무덤속으로
        GameObject hand = GameObject.Find("Hand");
        if (hand)
        {
            obj.transform.parent = hand.transform;
        }
        GameManager.Instance.createCardHand.Add(obj);

        GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
        // 카드 무덤속으로 들어가야함
        GameManager.Instance.cardHand.Remove(GameManager.Instance.cardList[cardNumber]);
        // 카드핸드에 있는 드로우카드가 cardHand리스트에서 지워지고,
        GameManager.Instance.cardHand.Add(GameManager.Instance.cardGrave[0]);
        // 무덤속 첫번쨰 카드가 Hand에 추가되고
        GameManager.Instance.cardGrave.RemoveAt(0);
        // Hand에 추가된 카드가 무덤속에서 사라짐
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
