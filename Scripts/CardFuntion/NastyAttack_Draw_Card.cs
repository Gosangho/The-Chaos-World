using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NastyAttack_Draw_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 8;
    private void Update()
    {
        if (mousetarget.Instance.nastyAttackBool)
        {
            switch (mousetarget.Instance.monster)
            {
                case MONSTER.SLIME1:
                    Slime1NastyAttack();
                    Debug.Log("switchSlime1NastyAttack");
                    break;
                case MONSTER.SLIME2:
                    Slime2NastyAttack();
                    Debug.Log("switchSlime2NastyAttack");
                    break;
                case MONSTER.SLIME3:
                    Slime3NastyAttack();
                    Debug.Log("switchSlime3NastyAttack");
                    break;
                case MONSTER.STAGE1BOSS:
                    Stage1BossNastyAttack();
                    Debug.Log("switchBossNastyAttack");
                    break;
                case MONSTER.GOBLIN1:
                    Goblin1NastyAttack();
                    Debug.Log("switchGoblin1NastyAttack");
                    break;
                case MONSTER.GOBLIN2:
                    Goblin2NastyAttack();
                    Debug.Log("switchGoblin2NastyAttack");
                    break;
                case MONSTER.SKELETON1:
                    Skeleton1NastyAttack();
                    Debug.Log("switchSkeleton1NastyAttack");
                    break;
                case MONSTER.SKELETON2:
                    Skeleton2NastyAttack();
                    Debug.Log("switchSkeleton2NastyAttack");
                    break;
                default:
                    Debug.Log("switchdefault");
                    break;
            }
        }
    }
    void Slime1NastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime1.Slime1Anim.SetTrigger("Slime1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime1CurrentDefense = 0;
            }
            GameManager.Instance.Slime1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime1CurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime2NastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime2.Slime2Anim.SetTrigger("Slime2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime2CurrentDefense = 0;
            }
            GameManager.Instance.Slime2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime2CurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime3NastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime3.Slime3Anim.SetTrigger("Slime3_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime3CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime3CurrentDefense = 0;
            }
            GameManager.Instance.Slime3CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime3CurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Stage1BossNastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.stage1_BossCurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.stage1_BossCurrentDefense = 0;
            }
            GameManager.Instance.stage1_BossCurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.stage1_BossCurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin1NastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin1.Goblin1Anim.SetTrigger("Goblin1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Goblin1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Goblin1CurrentDefense = 0;
            }
            GameManager.Instance.Goblin1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin1CurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin2NastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin2.Goblin2Anim.SetTrigger("Goblin2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Goblin2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Goblin2CurrentDefense = 0;
            }
            GameManager.Instance.Goblin2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin2CurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton1NastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Skeleton1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Skeleton1CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton1CurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton2NastyAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Skeleton2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Skeleton2CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton2CurrentDefense;
            cardDraw2();
            //+ 카드 드로우
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
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

    void cardDraw2()
    {
        GameObject obj = Instantiate(GameManager.Instance.cardGrave[0],
                new Vector3(mousetarget.Instance.targetPos.x, mousetarget.Instance.targetPos.y, 0), Quaternion.identity);
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
    }
}
