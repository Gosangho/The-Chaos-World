using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RewardBox : MonoBehaviour
{
    TextMeshProUGUI rewardButton;
    Animator BoxAnim;
    int ran;
    bool rewardBool = false;
    public IEnumerator rewardBoxButton()
    {
        BoxAnim.SetTrigger("Box_Triger");
        // 능력치들 초기화
        GameManager.Instance.Slime1CurrentAttack = 2;
        GameManager.Instance.Slime2CurrentAttack = 2;
        GameManager.Instance.Slime3CurrentAttack = 2;
        GameManager.Instance.Goblin1CurrentAttack = 2;
        GameManager.Instance.Goblin2CurrentAttack = 2;
        GameManager.Instance.Skeleton1CurrentAttack = 2;
        GameManager.Instance.Skeleton2CurrentAttack = 2;
        GameManager.Instance.stage1_BossCurrentAttack = 2;
        GameManager.Instance.Slime1CurrentDefense = 1;
        GameManager.Instance.Slime2CurrentDefense = 1;
        GameManager.Instance.Slime3CurrentDefense = 1;
        GameManager.Instance.Skeleton1CurrentDefense = 2;
        GameManager.Instance.Skeleton2CurrentDefense = 2;
        GameManager.Instance.Goblin1CurrentDefense = 2;
        GameManager.Instance.Goblin2CurrentDefense = 2;
        GameManager.Instance.stage1_BossCurrentDefense = 3;
        GameManager.Instance.playerAttackBuff = 0;
        GameManager.Instance.enemyAttackNerf = 0;
        GameManager.Instance.playerDefenseBuff = 0;
        // 스킬의 bool형 초기화
        GameManager.Instance.MadnessBool = false;
        GameManager.Instance.RoarAttackBool = false;
        GameManager.Instance.NormalDefenseBool = false;
        GameManager.Instance.ResolveBool = false;
        GameManager.Instance.WeaponBool = false;
        GameManager.Instance.AwakenBool = false;
        GameManager.Instance.ShieldBreakBool = false;
        GameManager.Instance.SwordRecallBool = false;
        GameManager.Instance.PenetrationBool = false;
        GameManager.Instance.DevilTransform = false;
        // 스킬의 버퍼들 초기화
        GameManager.Instance.AwakenTurnBuffer=99;
        GameManager.Instance.WeaponBreakTurnBuffer=99;
        GameManager.Instance.MadnessTurnBuffer=99;
        GameManager.Instance.PenetrationTurnBuffer=99;
        GameManager.Instance.NormalDefenseTurnBuffer=99;
        GameManager.Instance.ResolveTurnBuffer=99;
        GameManager.Instance.RoarAttackTurnBuffer=99;
        GameManager.Instance.ShiledBreakTurnBuffer=99;
        GameManager.Instance.SwordRecallTurnBuffer=99;
        GameManager.Instance.GameTurn = 0;
        // 여러 수치 초기화
        rewardBool = false;
        StopCoroutine(rewardBoxButton());
        Debug.Log("코루틴");
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        ran = Random.Range(0, GameManager.Instance.cardList.Count);
        Instantiate(GameManager.Instance.cardList[ran], new Vector3(0, 0, 0), Quaternion.identity);
        // 랜덤으로 뽑힌 카드 생성
        GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[ran]);
        // 뽑힌카드를 카드뭉치 리스트에 추가해줌
        yield return new WaitForSeconds(5.0f);
        // 5초의 시간 대기
        SceneManager.LoadScene(1);
        // 전투 종료시 씬 이동
    }
    void Start()
    {
        rewardButton = GetComponent<TextMeshProUGUI>();
        BoxAnim = GetComponent<Animator>();
    }

    public void ButtonBool()
    {
        rewardBool = true;  
    }
    private void Update()
    {
        if (rewardBool)
        {
            StartCoroutine(rewardBoxButton());
        }
    }
}
