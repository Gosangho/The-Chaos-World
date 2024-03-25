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
        // �ɷ�ġ�� �ʱ�ȭ
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
        // ��ų�� bool�� �ʱ�ȭ
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
        // ��ų�� ���۵� �ʱ�ȭ
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
        // ���� ��ġ �ʱ�ȭ
        rewardBool = false;
        StopCoroutine(rewardBoxButton());
        Debug.Log("�ڷ�ƾ");
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        ran = Random.Range(0, GameManager.Instance.cardList.Count);
        Instantiate(GameManager.Instance.cardList[ran], new Vector3(0, 0, 0), Quaternion.identity);
        // �������� ���� ī�� ����
        GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[ran]);
        // ����ī�带 ī�并ġ ����Ʈ�� �߰�����
        yield return new WaitForSeconds(5.0f);
        // 5���� �ð� ���
        SceneManager.LoadScene(1);
        // ���� ����� �� �̵�
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
