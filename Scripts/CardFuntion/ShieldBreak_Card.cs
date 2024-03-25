using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBreak_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 12;

    private void Update()
    {
        if (mousetarget.Instance.shieldBreakBool)
        {
            switch (mousetarget.Instance.monster)
            {
                case MONSTER.SLIME1:
                    Slime1ShieldBreak();
                    Debug.Log("switchSlime1ShieldBreak");
                    break;
                case MONSTER.SLIME2:
                    Slime2ShieldBreak();
                    Debug.Log("switchSlime2ShieldBreak");
                    break;
                case MONSTER.SLIME3:
                    Slime3ShieldBreak();
                    Debug.Log("switchSlime3ShieldBreak");
                    break;
                case MONSTER.STAGE1BOSS:
                    stage1BossShieldBreak();
                    Debug.Log("switchBossShieldBreak");
                    break;
                case MONSTER.GOBLIN1:
                    Goblin1ShieldBreak();
                    Debug.Log("switchGoblin1ShieldBreak");
                    break;
                case MONSTER.GOBLIN2:
                    Goblin2ShieldBreak();
                    Debug.Log("switchGoblin2ShieldBreak");
                    break;
                case MONSTER.SKELETON1:
                    Skeleton1ShieldBreak();
                    Debug.Log("switchskeleton1ShieldBreak");
                    break;
                case MONSTER.SKELETON2:
                    Skeleton2ShieldBreak();
                    Debug.Log("switchskeleton2ShieldBreak");
                    break;
                default:
                    Debug.Log("switchdefault");
                    break;
            }
        }
    }
    void Slime1ShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime1.Slime1Anim.SetTrigger("Slime1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.Slime1CurrentDefense -= 3;
            if (GameManager.Instance.Slime1CurrentDefense < 0)
            {// 예외설정
                GameManager.Instance.Slime1CurrentDefense = 0;
            }
            GameManager.Instance.Slime1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime1CurrentDefense;
            // 적을 때리는 공격력 = (고유몬스터의 방어력)-플레이어의 공격력버프+기본카드 공격력

            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime2ShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime2.Slime2Anim.SetTrigger("Slime2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.Slime2CurrentDefense -= 3;
            if (GameManager.Instance.Slime2CurrentDefense < 0)
            {
                GameManager.Instance.Slime2CurrentDefense = 0;
            }
            GameManager.Instance.Slime2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime2CurrentDefense;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime3ShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime3.Slime3Anim.SetTrigger("Slime3_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.Slime3CurrentDefense -= 3;
            if (GameManager.Instance.Slime3CurrentDefense<0)
            {
                GameManager.Instance.Slime3CurrentDefense = 0;
            }
            GameManager.Instance.Slime3CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime3CurrentDefense;
                

            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void stage1BossShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.stage1_BossCurrentDefense -= 3;
            if (GameManager.Instance.stage1_BossCurrentDefense < 0)
            {
                GameManager.Instance.stage1_BossCurrentDefense = 0;
            }
            GameManager.Instance.stage1_BossCurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.stage1_BossCurrentDefense;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin1ShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin1.Goblin1Anim.SetTrigger("Goblin1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.Goblin1CurrentDefense -= 3;
            if (GameManager.Instance.Goblin1CurrentDefense < 0)
            {
                GameManager.Instance.Goblin1CurrentDefense = 0;
            }
            GameManager.Instance.Goblin1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin1CurrentDefense;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin2ShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin2.Goblin2Anim.SetTrigger("Goblin2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.Goblin2CurrentDefense -= 3;
            if (GameManager.Instance.Goblin2CurrentDefense < 0)
            {
                GameManager.Instance.Goblin2CurrentDefense = 0;
            }
            GameManager.Instance.Goblin2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin2CurrentDefense;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton1ShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.Skeleton1CurrentDefense -= 3;
            if (GameManager.Instance.Skeleton1CurrentDefense < 0)
            {
                GameManager.Instance.Skeleton1CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton1CurrentDefense;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton2ShieldBreak()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // 엘리멘탈 게이지 -1
            GameManager.Instance.Skeleton2CurrentDefense -= 3;
            // 만약 턴을 증가시키면 효과종료
            if (GameManager.Instance.Skeleton2CurrentDefense < 0)
            {
                GameManager.Instance.Skeleton2CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton2CurrentDefense;
            mousetarget.Instance.shieldBreakBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// 엘리멘탈 게이지가 0이하일때 적을 공격한다면
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.shieldBreakBool = false;
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
}
