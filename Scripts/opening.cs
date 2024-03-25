using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class opening : MonoBehaviour
{
    Button gameStartButton;
    private void Start()
    {
        gameStartButton = GetComponent<Button>();
        gameStartButton.onClick.AddListener(gameStartManager);
    }
    public void gameStartManager()
    {
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
        GameManager.Instance.AwakenTurnBuffer = 99;
        GameManager.Instance.WeaponBreakTurnBuffer = 99;
        GameManager.Instance.MadnessTurnBuffer = 99;
        GameManager.Instance.PenetrationTurnBuffer = 99;
        GameManager.Instance.NormalDefenseTurnBuffer = 99;
        GameManager.Instance.ResolveTurnBuffer = 99;
        GameManager.Instance.RoarAttackTurnBuffer = 99;
        GameManager.Instance.ShiledBreakTurnBuffer = 99;
        GameManager.Instance.SwordRecallTurnBuffer = 99;
        GameManager.Instance.GameTurn = 0;
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        GameManager.Instance.playerCurrentHp = 10;
        GameManager.Instance.Slime1CurrentHp = 10;
        GameManager.Instance.Slime2CurrentHp = 10;
        GameManager.Instance.Slime3CurrentHp = 10;
        GameManager.Instance.Skeleton1CurrentHp = 10;
        GameManager.Instance.Skeleton2CurrentHp = 10;
        GameManager.Instance.Goblin1CurrentHp = 10;
        GameManager.Instance.Goblin2CurrentHp = 10;
        GameManager.Instance.stage1_BossCurrentHp = 10;
        SceneManager.LoadScene(1);
    }
}
