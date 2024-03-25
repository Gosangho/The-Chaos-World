using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class GameManager : MonoBehaviour
{
    //싱글톤화
    #region
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion
    public bool BattleBool = true; // 전투시작시 true
    [Header("변수")]
    public int Slime1CurrentHp = 10; // tag : Slime1
    public int Slime1CurrentAttack = 2;
    public int Slime1CurrentDefense = 1;
    public bool Slime1AttackBool = false;
    public int Slime2CurrentHp = 10;
    public int Slime2CurrentAttack = 2;
    public int Slime2CurrentDefense = 1;
    public bool Slime2AttackBool = false;
    public int Slime3CurrentHp = 10;
    public int Slime3CurrentAttack = 2;
    public int Slime3CurrentDefense = 1;
    public bool Slime3AttackBool = false;
    public int Goblin1CurrentHp = 10;
    public int Goblin1CurrentAttack = 2;
    public int Goblin1CurrentDefense = 2;
    public bool Goblin1AttackBool = false;
    public int Goblin2CurrentHp = 10;
    public int Goblin2CurrentAttack = 2;
    public int Goblin2CurrentDefense = 2;
    public bool Goblin2AttackBool = false;
    public int Skeleton1CurrentHp = 10;
    public int Skeleton1CurrentAttack = 2;
    public int Skeleton1CurrentDefense = 2;
    public bool Skeleton1AttackBool = false;
    public int Skeleton2CurrentHp = 10;
    public int Skeleton2CurrentAttack = 2;
    public int Skeleton2CurrentDefense = 2;
    public bool Skeleton2AttackBool = false;
    public int stage1_BossCurrentHp = 10;
    public int stage1_BossCurrentAttack = 2;
    public int stage1_BossCurrentDefense = 3;
    public bool stage1_BossAttackBool = false;
    public bool DevilTransform = false;
    public int playerAttackBuff = 0;
    public int playerDefenseBuff = 0;
    public int playerCurrentHp = 10;
    public int playerMaxHp = 10;
    public int playerCurrentAttack = 0;
    public int playerCurrentAttackBuffer;
    public int playerCurrentDefense = 1;
    public int playerCurrentDefenseBuffer;
    public int enemyDefenseNerf = 0;
    public int enemyAttackNerf = 0;
    public int enemyCurrentAttackBuffer;
    public int enemyCurrentAttack = 5;
    public int enemyCurrentHp = 10;
    public int enemyMaxHp = 10;
    public int enemyCurrentDefense;
    public int enemyCurrentDefenseBuffer;
    public int Gold = 10; // 현재 가지고있는 골드(이미지 추가예정)
    public int maxElementalgage = 5;
    public int currentElementalgage = 3; // 카드를 사용할때 사용하는 자원
    public int GameTurn; // 게임 턴
    public int WeaponBreakTurnBuffer;
    public int AwakenTurnBuffer;
    public int MadnessTurnBuffer;
    public int PenetrationTurnBuffer;
    public int NormalDefenseTurnBuffer;
    public int ResolveTurnBuffer;
    public int RoarAttackTurnBuffer;
    public int ShiledBreakTurnBuffer;
    public int SwordRecallTurnBuffer;
    public int cardNumberindex;
    //int CardCount; // 현재 가지고있는 카드갯수
    //int MaxCardCount = 30; // 가질 수 있는 최대 카드갯수
    [Header("Card Bool")]
    public bool MadnessBool = false;
    public bool RoarAttackBool = false;
    public bool NormalDefenseBool = false;
    public bool ResolveBool = false;
    public bool WeaponBool = false;
    public bool AwakenBool = false;
    public bool ShieldBreakBool = false;
    public bool SwordRecallBool = false;
    public bool PenetrationBool = false;

    [Header("오브젝트")]
    public GameObject AttackBlood_Card;
    public GameObject Awaken_Card;
    public GameObject BattleJoy_draw_Card;
    public GameObject Boostmind_Card;
    public GameObject DevilTransform_Card;
    public GameObject KickAttack_draw_Card;
    public GameObject LuckLeap_Card;
    public GameObject Madness_Card;
    public GameObject NastyAttack_draw_Card;
    public GameObject NormalAttack_Card;
    public GameObject Normaldefense_Card;
    public GameObject Penetration_Card;
    public GameObject Resolve_Card;
    public GameObject RoarAttack_Card;
    public GameObject ShieldBreak_Card;
    public GameObject SurpriseAttack_Card;
    public GameObject SwordRecall_Card;
    public GameObject WeaponBreak_Card;
    [Header("게임에서 존재하는 카드목록")]
    public List<GameObject> cardList = new List<GameObject>(); // 게임에서 존재하는 전체 카드목록
    [Header("손에 들고있는 카드목록")]
    public List<GameObject> cardHand = new List<GameObject>();
    [Header("카드무덤속 카드목록")]
    public List<GameObject> cardGrave = new List<GameObject>();
    [Header("화면에서 보여지는 Create된 카드들")]
    public List<GameObject> createCardHand = new List<GameObject>();
    // 이 카드목록들을 다음턴으로 진행을 누르면 삭제시켜줘야 함

    private void Start()
    {
        WeaponBreakTurnBuffer=99;
        AwakenTurnBuffer=99;
        MadnessTurnBuffer=99;
        PenetrationTurnBuffer=99;
        NormalDefenseTurnBuffer=99;
        ResolveTurnBuffer=99;
        RoarAttackTurnBuffer=99;
        ShiledBreakTurnBuffer=99;
        SwordRecallTurnBuffer=99;
    //float targetAspect = 1920.0f / 1080.0f;
    //float windowAspect = (float)Screen.width / (float)Screen.height;
    //float scaleHeight = windowAspect / targetAspect;
    //Rect rect = Camera.main.rect;

    //if (scaleHeight < 1.0f)
    //{
    //    rect.width = 1.0f;
    //    rect.height = scaleHeight;
    //    rect.x = 0;
    //    rect.y = (1.0f - scaleHeight) / 2.0f;
    //}
    //else
    //{
    //    float scalewidth = 1.0f / scaleHeight;
    //    rect.width = scalewidth;
    //    rect.height = 1.0f;
    //    rect.x = (1.0f - scalewidth) / 2.0f;
    //    rect.y = 0;
    //}

    //Camera.main.rect = rect;


        cardList.Add(AttackBlood_Card); // 0
        cardList.Add(Awaken_Card); // 1
        cardList.Add(BattleJoy_draw_Card); // 2
        cardList.Add(Boostmind_Card); // 3
        cardList.Add(DevilTransform_Card); // 4
        cardList.Add(KickAttack_draw_Card); // 5
        cardList.Add(LuckLeap_Card); // 6
        cardList.Add(Madness_Card); // 7
        cardList.Add(NastyAttack_draw_Card); // 8
        cardList.Add(Penetration_Card); // 9
        cardList.Add(Resolve_Card); // 10
        cardList.Add(RoarAttack_Card); // 11
        cardList.Add(ShieldBreak_Card); // 12
        cardList.Add(SurpriseAttack_Card); // 13
        cardList.Add(SwordRecall_Card); // 14
        cardList.Add(WeaponBreak_Card); // 15
        //cardList.Add(Normaldefense_Card); 기본제공카드
        //cardList.Add(NormalAttack_Card); 기본제공카드
        cardGrave.Add(NormalAttack_Card);
        cardGrave.Add(NormalAttack_Card);
        cardGrave.Add(NormalAttack_Card);
        cardGrave.Add(Normaldefense_Card);
        cardGrave.Add(Normaldefense_Card);
        cardGrave.Add(Normaldefense_Card);
        cardGrave.Add(SurpriseAttack_Card);
        firstRandomCard();
        // (cardList = 게임에서 존재하는 카드목록)
        // 상점이나 스테이지 클리어보상으로 cardList에 있는 카드들을 랜덤으로 instance
        // cardGrave = 게임을 진행하면서 획득한 카드를 cardGrave List에 넣어준다.
        // ex) cardGrave에 10장이 있다면 그중 5장을 뽑아서 처음시작시 instance
        // (만약 아이템이나 유물등의 특성을통해 처음시작시 6장을 뽑게된다면 6으로 바꿔주자.)
        // cardHand List에 추가해주고 추가된 카드를 cardGrave List에서 제거시켜준다.
        // draw카드를 사용시 cardGrave의 가장 위에있는 카드를 cardHand에 추가시켜준다.
    }

    //카드뽑기
    public void firstRandomCard()
    {
        for (int i = 0; i < 5; i++)
        {// 5개 뺸 나머지
            int ran = Random.Range(0, cardGrave.Count);
            //Debug.Log(cardGrave[ran]);
            cardHand.Add(cardGrave[ran]); // cardGrave에서 뽑힌 카드를 cardHand에 추가
            cardGrave.RemoveAt(ran); // cardHand에 추가된 카드는 cardGrave에서 제거
        }
        //int ran = Random.Range(0, cardList.Count);
        //for (int i = 0; i < cardranList.Count; i++)
        //{
        //    if (!(cardranList.Count == 0) && ran == cardranList[i])
        //    {
        //        ran = Random.Range(0, cardList.Count);
        //        i--;
        //    }
        //    cardranList.Add(ran);
        //    Debug.Log(cardranList[i]);
        //}
    }
}
