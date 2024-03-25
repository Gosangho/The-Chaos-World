using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AttackBlood_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 0;

    private void Update()
    {
        if (mousetarget.Instance.attackBloodBool)
        {
            switch (mousetarget.Instance.monster)
            {
                case MONSTER.SLIME1:
                    Slime1AttackBlood();
                    Debug.Log("switchSlime1AttackBlood");
                    break;
                case MONSTER.SLIME2:
                    Slime2AttackBlood();
                    Debug.Log("switchSlime2AttackBlood");
                    break;
                case MONSTER.SLIME3:
                    Slime3AttackBlood();
                    Debug.Log("switchSlime3AttackBlood");
                    break;
                case MONSTER.STAGE1BOSS:
                    stage1BossAttackBlood();
                    Debug.Log("switchBossAttackBlood");
                    break;
                case MONSTER.GOBLIN1:
                    Goblin1AttackBlood();
                    Debug.Log("switchgoblin1AttackBlood");
                    break;
                case MONSTER.GOBLIN2:
                    Goblin2AttackBlood();
                    Debug.Log("switchgoblin2AttackBlood");
                    break;
                case MONSTER.SKELETON1:
                    Skeleton1AttackBlood();
                    Debug.Log("switchskeleton1AttackBlood");
                    break;
                case MONSTER.SKELETON2:
                    Skeleton2AttackBlood();
                    Debug.Log("switchskeleton2AttackBlood");
                    break;
                default:
                    Debug.Log("switchdefault");
                    break;
            }
        }
    }
    void Slime1AttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime1.Slime1Anim.SetTrigger("Slime1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime1CurrentDefense = 0;
            }
            
            GameManager.Instance.Slime1CurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.Slime1CurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력
            // 공격력 : 어택버프+기본대미지 4
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime2AttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime2.Slime2Anim.SetTrigger("Slime2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime2CurrentDefense = 0;
            }
            GameManager.Instance.Slime2CurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.Slime2CurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력
            // 공격력 : 어택버프+기본대미지 4
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime3AttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime3.Slime3Anim.SetTrigger("Slime3_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime3CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime3CurrentDefense = 0;
            }
            GameManager.Instance.Slime3CurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.Slime3CurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력
            // 공격력 : 어택버프+기본대미지 4
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void stage1BossAttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.stage1_BossCurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.stage1_BossCurrentDefense = 0;
            }
            GameManager.Instance.stage1_BossCurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.stage1_BossCurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력
            // 공격력 : 어택버프+기본대미지 4
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin1AttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin1.Goblin1Anim.SetTrigger("Goblin1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Goblin1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Goblin1CurrentDefense = 0;
            }
            GameManager.Instance.Goblin1CurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.Goblin1CurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력
            // 공격력 : 어택버프+기본대미지 4
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin2AttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin2.Goblin2Anim.SetTrigger("Goblin2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Goblin2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Goblin2CurrentDefense = 0;
            }
            GameManager.Instance.Goblin2CurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.Goblin2CurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력
            // 공격력 : 어택버프+기본대미지 4
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton1AttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Skeleton1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Skeleton1CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton1CurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.Skeleton1CurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력
            // 공격력 : 어택버프+기본대미지 4
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton2AttackBlood()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {// 적에게 4의 피해를 입히고 체력을 3 회복한다.
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Skeleton2CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Skeleton2CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton2CurrentHp -= (GameManager.Instance.playerAttackBuff + 4)
                - GameManager.Instance.Skeleton2CurrentDefense;
            GameManager.Instance.playerCurrentHp += 3;
            // 체력 3 회복
            mousetarget.Instance.attackBloodBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
            if (GameManager.Instance.playerCurrentHp >= GameManager.Instance.playerMaxHp)
            {// 플레이어 현재 체력이 최대체력을 상회할 수 없다.
                GameManager.Instance.playerCurrentHp = GameManager.Instance.playerMaxHp;
            }
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.attackBloodBool = false;
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
        if (GameManager.Instance.Gold>=30)
        {// 골드가 50원 이상일때
            GameManager.Instance.Gold -= 30;
            Debug.Log("store");
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // 카드뭉치 리스트에 카드리스트[cardnumber]추가
            Destroy(gameObject);
        }
    }
}
