using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Turn : MonoBehaviour
{
    public TextMeshProUGUI turnText;
    public bool slimeTurnAttack = false;
    public bool goBlinTurnAttack = false;
    public bool skeletonTurnAttack = false;
    public bool stage1BossTurnAttack = false;

    private void Start()
    {
        turnText = GetComponent<TextMeshProUGUI>(); // 캐싱
        cardHandInstance();
    }
    public void cardHandInstance()
    {
        float j = -8f; // 카드의 가장 첫번째 자리값(X값)
        
        for (int i = 0; i < GameManager.Instance.cardHand.Count; i++)
        {
            //Debug.Log(GameManager.Instance.cardHand.Count);
            j += 1.7f;
            GameObject obj = Instantiate(GameManager.Instance.cardHand[i], new Vector3(i + j, -3, 0), Quaternion.identity);
            GameObject hand = GameObject.Find("Hand");
            if (hand)
            {
                obj.transform.parent = hand.transform;
            }
            GameManager.Instance.createCardHand.Add(obj);
        }
    }
    public void turnManager()
    {// 턴 종료 버튼을 누를경우 실행
        GameManager.Instance.GameTurn++; // 클릭하면 턴이 증가
        GameManager.Instance.currentElementalgage = 3;
        cardDestroy();
        // 1턴에서 생성된 CardHand(clone)들 제거

        ResetSystem();
        // 1턴에서 뽑힌 5장의 카드를 cardGrave마지막에 추가해주고

        turnCard();
        // cardGrave위의 5장을 cardHand에 넣어줌
        enemyAttackBool(); // enemy의 attackBool=true
        
        if (SceneManager.GetActiveScene().buildIndex==2)// 슬라임 스테이지
        {// 턴종료 버튼을 눌렀을때 2번 씬이라면(몬스터가 플레이어에게 대미지를 주는 부분)
            if (GameManager.Instance.Slime1AttackBool&&GameManager.Instance.Slime1CurrentHp>0)
            {// 슬라임 1

                slime1.Slime1Anim.SetTrigger("Slime1_Attack_Triger");// 슬라임 공격모션
                Character.anim.SetTrigger("Player_Hit_Triger"); // 플레이어가 피격당하는 애니메이션
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool이 트루라면
                    GameManager.Instance.Slime1CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration이 트루라면
                    GameManager.Instance.Slime1CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff<0)
                {// 디펜스 버프가 음수라면
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff>=GameManager.Instance.Slime1CurrentAttack)
                {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
                    // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Slime1CurrentAttack;
                    // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                    // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                    // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                    // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
                }
                else
                {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Slime1CurrentAttack - 
                        (GameManager.Instance.playerDefenseBuff);
                    // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                    // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
                }
                
                GameManager.Instance.Slime1AttackBool = false;
                if (GameManager.Instance.Slime1AttackBool==false&&GameManager.Instance.PenetrationBool==false)
                {
                    GameManager.Instance.Slime1CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Slime2AttackBool&&GameManager.Instance.Slime2CurrentHp>0)
            {// 슬라임 2
                slime2.Slime2Anim.SetTrigger("Slime2_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool이 트루라면
                    GameManager.Instance.Slime2CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration이 트루라면
                    GameManager.Instance.Slime2CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// 디펜스 버프가 음수라면
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Slime2CurrentAttack)
                {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
                    // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Slime2CurrentAttack;
                    // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                    // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                    // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                    // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
                }
                else
                {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Slime2CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                    // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
                }

                GameManager.Instance.Slime2AttackBool = false;
                if (GameManager.Instance.Slime2AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Slime2CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Slime3AttackBool && GameManager.Instance.Slime3CurrentHp > 0)
            {// 슬라임 3
                slime3.Slime3Anim.SetTrigger("Slime3_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool이 트루라면
                    GameManager.Instance.Slime3CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration이 트루라면
                    GameManager.Instance.Slime3CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// 디펜스 버프가 음수라면
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Slime3CurrentAttack)
                {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
                    // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Slime3CurrentAttack;
                    // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                    // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                    // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                    // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
                }
                else
                {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Slime3CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                    // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
                }
                
                GameManager.Instance.Slime3AttackBool = false;
                if (GameManager.Instance.Slime3AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Slime3CurrentAttack = 2;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex==3)// 고블린 스테이지
        {
            if (GameManager.Instance.Goblin1AttackBool&&GameManager.Instance.Goblin1CurrentHp>0)
            {// 고블린 1
                Goblin1.Goblin1Anim.SetTrigger("Goblin1_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool이 트루라면
                    GameManager.Instance.Goblin1CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration이 트루라면
                    GameManager.Instance.Goblin1CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// 디펜스 버프가 음수라면
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Goblin1CurrentAttack)
                {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
                    // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Goblin1CurrentAttack;
                    // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                    // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                    // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                    // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
                }
                else
                {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Goblin1CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                    // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
                }

                GameManager.Instance.Goblin1AttackBool = false;
                if (GameManager.Instance.Goblin1AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Goblin1CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Goblin2AttackBool && GameManager.Instance.Goblin2CurrentHp > 0)
            {// 고블린 2
                Goblin2.Goblin2Anim.SetTrigger("Goblin2_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool이 트루라면
                    GameManager.Instance.Goblin2CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration이 트루라면
                    GameManager.Instance.Goblin2CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }


                if (GameManager.Instance.playerDefenseBuff < 0)
                {// 디펜스 버프가 음수라면
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Goblin2CurrentAttack)
                {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
                    // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Goblin2CurrentAttack;
                    // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                    // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                    // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                    // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
                }
                else
                {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Goblin2CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                    // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
                }

                GameManager.Instance.Goblin2AttackBool = false;
                if (GameManager.Instance.Goblin2AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Goblin2CurrentAttack = 2;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex==5)// 스켈레톤 스테이지
        {
            if (GameManager.Instance.Skeleton1AttackBool&&GameManager.Instance.Skeleton1CurrentHp>0)
            {// 스켈레톤 1
                Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");

                if (GameManager.Instance.AwakenBool)
                {// AwakenBool이 트루라면
                    GameManager.Instance.Skeleton1CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration이 트루라면
                    GameManager.Instance.Skeleton1CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// 디펜스 버프가 음수라면
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Skeleton1CurrentAttack)
                {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
                    // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Skeleton1CurrentAttack;
                    // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                    // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                    // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                    // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
                }
                else
                {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Skeleton1CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                    // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
                }

                GameManager.Instance.Skeleton1AttackBool = false;
                if (GameManager.Instance.Skeleton1AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Skeleton1CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Skeleton2AttackBool && GameManager.Instance.Skeleton2CurrentHp > 0)
            {// 스켈레톤 2
                Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");

                if (GameManager.Instance.AwakenBool)
                {// AwakenBool이 트루라면
                    GameManager.Instance.Skeleton2CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration이 트루라면
                    GameManager.Instance.Skeleton2CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// 디펜스 버프가 음수라면
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Skeleton2CurrentAttack)
                {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
                    // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Skeleton2CurrentAttack;
                    // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                    // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                    // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                    // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
                }
                else
                {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Skeleton2CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                    // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
                }

                GameManager.Instance.Skeleton2AttackBool = false;
                if (GameManager.Instance.Skeleton2AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Skeleton2CurrentAttack = 2;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex==6)// 보스 스테이지
        {
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Attack_Triger");
            Character.anim.SetTrigger("Player_Hit_Triger");

            if (GameManager.Instance.AwakenBool)
            {// AwakenBool이 트루라면
                GameManager.Instance.stage1_BossCurrentAttack = 0;
            }

            if (GameManager.Instance.PenetrationBool)
            {// penetration이 트루라면
                GameManager.Instance.stage1_BossCurrentAttack = 0;
                GameManager.Instance.PenetrationBool = false;
            }

            if (GameManager.Instance.playerDefenseBuff < 0)
            {// 디펜스 버프가 음수라면
                GameManager.Instance.playerDefenseBuff = 0;
            }

            if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.stage1_BossCurrentAttack)
            {// 플레이어의 방어력버프가 슬라임1의 공격력보다 크거나 같다면
             // 플레이어의 방어력버프가 5 슬라임1의 공격력 2
                GameManager.Instance.playerDefenseBuff -= GameManager.Instance.stage1_BossCurrentAttack;
                // 플레이어의 디펜스버프를 슬라임1의 공격력만큼 마이너스
                // 공격을 안하고 끝이지만 슬라임1의 공격모션(애니메이션)이 나와줘야하고
                // 플레이어의 방어력버프를 수치화해서 슬라임1이 공격했을경우
                // 플레이어의 방어력버프 수치가 줄어드는 것을 수치화 + 임펙트 추가
            }
            else
            {// 슬라임의 공격력이 플레이어의 방어력 버프보다 크다면
                GameManager.Instance.playerCurrentHp -= GameManager.Instance.stage1_BossCurrentAttack -
                    (GameManager.Instance.playerDefenseBuff);
                // 슬라임의 공격력에서 플레이어의 방어력수치만큼 빼준다음
                // 뺀 결과값만큼 플레이어의 체력수치를 빼준다.
            }

            GameManager.Instance.stage1_BossAttackBool = false;
            if (GameManager.Instance.stage1_BossAttackBool == false && GameManager.Instance.PenetrationBool == false)
            {
                GameManager.Instance.stage1_BossCurrentAttack = 2;
            }

        }
        // 적의공격 후(false -> true -> 적 공격 -> enemyAttack=false -> 내턴 시작)

        // 적의 공격이 끝나면 턴 증가
        // 플레이어턴(짝수턴), 적의턴(홀수턴)
        // 플레이어턴(0)-> 턴종료(턴++) -> 적의턴(1)플레이어 공격 -> 턴종료(턴++) -> 플레이어턴(2) 
        PlayerBuffReset(); // 각종 변수들 초기화
        createNewCard();
        // cardHand를 다시 Instante해줌
    }
    public void DevilTransform()
    {
        if (GameManager.Instance.DevilTransform)
        {// 악마의형상의 true상태라면
            GameManager.Instance.playerCurrentHp = GameManager.Instance.playerCurrentHp - 20;
        }
        // 만약 적이 죽었다면 Reset
    }
    void ResetSystem()
    {
        for (int i = 0; i < GameManager.Instance.cardHand.Count; i++)
        {// 0 1 2 3 4
            Debug.Log(GameManager.Instance.cardHand.Count);

            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardHand[i]);
            // 턴 종료시 cardHand에 있는 List들을 cardGrave에 추가
            Debug.Log(GameManager.Instance.cardGrave.Count);
        }
        GameManager.Instance.cardHand.Clear();
        // cardHand리스트 클리어
    }
    void turnCard()
    {
        for (int i = 0; i < 5; i++)
        {
            GameManager.Instance.cardHand.Add(GameManager.Instance.cardGrave[0]);
            // cardGrave[0]~cardGrave[4] 사라지나 ? 아닐텐데
            // cardHand리스트에 cardGrave리스트의 가장위에있는 5장을 넣어준다.
            GameManager.Instance.cardGrave.RemoveAt(0);
            // cardHand리스트에 넣은 카드는 cardGrave리스트에서 지워준다.
        }
    }
    float j = -8f; // 카드의 가장 첫번째 자리값(X값)
    void createNewCard()
    {
        for (int i = 0; i < 5; i++)
        {// cardHand.count만큼 카드 생성
            j += 1.7f;
            GameObject obj = Instantiate(GameManager.Instance.cardHand[i], new Vector3(i + j, -3, 0), Quaternion.identity);
            GameObject hand = GameObject.Find("Hand");
            if (hand)
            {
                obj.transform.parent = hand.transform;
            }
            GameManager.Instance.createCardHand.Add(obj);
        }
        j = -8f;
    }
    void cardDestroy()
    {
        for (int i = 0; i < GameManager.Instance.createCardHand.Count; i++)
        {
            Destroy(GameManager.Instance.createCardHand[i]);
            // 1턴에 Create된 클론 카드들
        }
        GameManager.Instance.createCardHand.Clear();
    }
    void enemyAttackBool()
    {
        GameManager.Instance.Slime1AttackBool = true;
        GameManager.Instance.Slime2AttackBool = true;
        GameManager.Instance.Slime3AttackBool = true;
        GameManager.Instance.Goblin1AttackBool = true;
        GameManager.Instance.Goblin2AttackBool = true;
        GameManager.Instance.Skeleton1AttackBool = true;
        GameManager.Instance.Skeleton2AttackBool = true;
        GameManager.Instance.stage1_BossAttackBool = true;
    }
    void PlayerBuffReset()
    {
        if (GameManager.Instance.GameTurn - GameManager.Instance.AwakenTurnBuffer == 2)
        {// GameTurn과 AwakenTurn(2턴간 효과유지)을 뺐을때 2가 나온다면(Awaken카드효과부분)
            GameManager.Instance.AwakenBool = false;
            GameManager.Instance.Slime1CurrentAttack = 2;
            GameManager.Instance.Slime2CurrentAttack = 2;
            GameManager.Instance.Slime3CurrentAttack = 2;
            GameManager.Instance.Goblin1CurrentAttack = 2;
            GameManager.Instance.Goblin2CurrentAttack = 2;
            GameManager.Instance.Skeleton1CurrentAttack = 2;
            GameManager.Instance.Skeleton2CurrentAttack = 2;
            GameManager.Instance.stage1_BossCurrentAttack = 2;
            // 어웨이크턴 2턴이 지났을경우 몬스터의 공격력 수치 초기화
            // 효과종료
        }

        if (GameManager.Instance.GameTurn-GameManager.Instance.MadnessTurnBuffer==2)
        {// 2턴이 지난다면
            GameManager.Instance.MadnessBool = false;
            GameManager.Instance.playerAttackBuff -= 3;
        }

        if (GameManager.Instance.GameTurn-GameManager.Instance.ResolveTurnBuffer==1)
        {
            GameManager.Instance.ResolveBool = false;
            GameManager.Instance.playerAttackBuff -= 2;
        }

        if (GameManager.Instance.GameTurn-GameManager.Instance.RoarAttackTurnBuffer==2)
        {
            GameManager.Instance.RoarAttackBool = false;
            GameManager.Instance.Slime1CurrentAttack += 3;
            GameManager.Instance.Slime2CurrentAttack += 3;
            GameManager.Instance.Slime3CurrentAttack += 3;
            GameManager.Instance.Skeleton1CurrentAttack += 3;
            GameManager.Instance.Skeleton2CurrentAttack += 3;
            GameManager.Instance.Goblin1CurrentAttack += 3;
            GameManager.Instance.Goblin2CurrentAttack += 3;
            GameManager.Instance.stage1_BossCurrentAttack += 3;
        }

        if (GameManager.Instance.GameTurn-GameManager.Instance.SwordRecallTurnBuffer==2)
        {
            GameManager.Instance.SwordRecallBool = false;
            GameManager.Instance.playerAttackBuff -= 15;
        }

        if (GameManager.Instance.GameTurn-GameManager.Instance.WeaponBreakTurnBuffer==2)
        {
            GameManager.Instance.WeaponBool = false;
            GameManager.Instance.Slime1CurrentAttack += 3;
            GameManager.Instance.Slime2CurrentAttack += 3;
            GameManager.Instance.Slime3CurrentAttack += 3;
            GameManager.Instance.Skeleton1CurrentAttack += 3;
            GameManager.Instance.Skeleton2CurrentAttack += 3;
            GameManager.Instance.Goblin1CurrentAttack += 3;
            GameManager.Instance.Goblin2CurrentAttack += 3;
            GameManager.Instance.stage1_BossCurrentAttack += 3;
        }


        GameManager.Instance.Slime1CurrentDefense = 1;
        GameManager.Instance.Slime2CurrentDefense = 1;
        GameManager.Instance.Slime3CurrentDefense = 1;
        GameManager.Instance.Skeleton1CurrentDefense = 2;
        GameManager.Instance.Skeleton2CurrentDefense = 2;
        GameManager.Instance.Goblin1CurrentDefense = 2;
        GameManager.Instance.Goblin2CurrentDefense = 2;
        GameManager.Instance.stage1_BossCurrentDefense = 3;
        GameManager.Instance.playerDefenseBuff = 0; // 1턴간 지속되는 플레이어 방어수치 초기화
        
    // 디펜스 수치 초기화(1턴간 지속되는)
    }
}
