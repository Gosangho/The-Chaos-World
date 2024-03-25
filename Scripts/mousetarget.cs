using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetarget : MonoBehaviour
{
    private static mousetarget instance = null;

    public static mousetarget Instance
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

    Ray ray;
    RaycastHit hit;
    public Vector3 mousePos, transPos, targetPos, firstTargetPos;
    

    public GameObject target;
    bool isClick = false;
    public MONSTER monster = default;
    public LayerMask LayerMask;
    public bool attackBloodBool = false;
    public bool awakenBool = false;
    public bool battleJoyBool = false;
    public bool boostMindBool = false;
    public bool devilTransformBool = false;
    public bool kickAttackBool = false;
    public bool luckLeapBool = false;
    public bool madnessBool = false;
    public bool nastyAttackBool = false;
    public bool normalAttackBool = false;
    public bool normalDefenseBool = false;
    public bool penetrationBool = false;
    public bool resolveBool = false;
    public bool roarAttackBool = false;
    public bool shieldBreakBool = false;
    public bool surpriseAttackBool = false;
    public bool swordRecallBool = false;
    public bool weaponBreakBool = false;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {// 카드를 움직이는 부분
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 30.0f, LayerMask.GetMask("Card")))
            {
                targetPos = hit.transform.position;
                firstTargetPos = hit.transform.position;
                // 오브젝트의 원래위치
                //if (hit.transform.gameObject.)
                //{
                // hit의 tag를 저장할 변수를 만들어야함
                Debug.Log(tag); // 저장된 변수

                isClick = true;
                target = hit.transform.gameObject;
                //hit.transform.position = targetPos;
                // 마우스의 속도를 빠르게하면 벗어나는 버그(나중에)
                target.GetComponent<Collider>().enabled = false;
                Debug.Log("mouseDown" + target);
                //}
            }
        }
        if (isClick && target)
        {
            mousePos = Input.mousePosition;
            transPos = Camera.main.ScreenToWorldPoint(mousePos);
            target.transform.position = transPos;
            target.transform.position = new Vector3(transPos.x, transPos.y, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            isClick = false;
            Debug.Log("mouseUp" + target);
            
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {// 어떤몬스터를 타격할지 결정할 ray
                if (hit.transform.CompareTag("Slime1") && target.transform.CompareTag("AttackBlood"))
                {// ray를 쏜 hit이 Slime1이고 AttackBlood카드를 사용할때
                    Debug.Log("mouseSlime1");
                    attackBloodBool = true;
                    monster = MONSTER.SLIME1;
                }
                else if (hit.transform.CompareTag("Slime2") && target.transform.CompareTag("AttackBlood"))
                {// ray를 쏜 hit이 Slime1이라면
                    Debug.Log("mouseSlime2");
                    attackBloodBool = true;
                    monster = MONSTER.SLIME2;
                }
                else if (hit.transform.CompareTag("Slime3") && target.transform.CompareTag("AttackBlood"))
                {// ray를 쏜 hit이 Slime1이라면
                    Debug.Log("mouseSlime3");
                    attackBloodBool = true;
                    monster = MONSTER.SLIME3;
                }
                else if (hit.transform.CompareTag("stage1Boss") && target.transform.CompareTag("AttackBlood"))
                {// ray를 쏜 hit이 Slime1이라면
                    Debug.Log("stage1Boss");
                    attackBloodBool = true;
                    monster = MONSTER.STAGE1BOSS;
                }
                else if (hit.transform.CompareTag("Goblin1") && target.transform.CompareTag("AttackBlood"))
                {
                    Debug.Log("Goblin1");
                    attackBloodBool = true;
                    monster = MONSTER.GOBLIN1;
                }
                else if (hit.transform.CompareTag("Goblin2") && target.transform.CompareTag("AttackBlood"))
                {
                    Debug.Log("Goblin2");
                    attackBloodBool = true;
                    monster = MONSTER.GOBLIN2;
                }
                else if (hit.transform.CompareTag("Skeleton1") && target.transform.CompareTag("AttackBlood"))
                {
                    Debug.Log("Skeleton1");
                    attackBloodBool = true;
                    monster = MONSTER.SKELETON1;
                }
                else if (hit.transform.CompareTag("Skeleton2") && target.transform.CompareTag("AttackBlood"))
                {
                    Debug.Log("Skeleton2");
                    attackBloodBool = true;
                    monster = MONSTER.SKELETON2;
                }
                else if (hit.transform.CompareTag("Slime1") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("Slime1");
                    normalAttackBool = true;
                    monster = MONSTER.SLIME1;
                }
                else if (hit.transform.CompareTag("Slime2") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("Slime2");
                    normalAttackBool = true;
                    monster = MONSTER.SLIME2;
                }
                else if (hit.transform.CompareTag("Slime3") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("Slime3");
                    normalAttackBool = true;
                    monster = MONSTER.SLIME3;
                }
                else if (hit.transform.CompareTag("Skeleton1") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("Skeleton1");
                    normalAttackBool = true;
                    monster = MONSTER.SKELETON1;
                }
                else if (hit.transform.CompareTag("Skeleton2") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("Skeleton2");
                    normalAttackBool = true;
                    monster = MONSTER.SKELETON2;
                }
                else if (hit.transform.CompareTag("Goblin1") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("Goblin1");
                    normalAttackBool = true;
                    monster = MONSTER.GOBLIN1;
                }
                else if (hit.transform.CompareTag("Goblin2") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("Goblin2");
                    normalAttackBool = true;
                    monster = MONSTER.GOBLIN2;
                }
                else if (hit.transform.CompareTag("stage1Boss") && target.transform.CompareTag("NormalAttack"))
                {
                    Debug.Log("stage1Boss");
                    normalAttackBool = true;
                    monster = MONSTER.STAGE1BOSS;
                }
                else if (hit.transform.CompareTag("Slime1") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("Slime1");
                    kickAttackBool = true;
                    monster = MONSTER.SLIME1;
                }
                else if (hit.transform.CompareTag("Slime2") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("Slime2");
                    kickAttackBool = true;
                    monster = MONSTER.SLIME2;
                }
                else if (hit.transform.CompareTag("Slime3") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("Slime3");
                    kickAttackBool = true;
                    monster = MONSTER.SLIME3;
                }
                else if (hit.transform.CompareTag("Skeleton1") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("Skeleton1");
                    kickAttackBool = true;
                    monster = MONSTER.SKELETON1;
                }
                else if (hit.transform.CompareTag("Skeleton2") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("Skeleton2");
                    kickAttackBool = true;
                    monster = MONSTER.SKELETON2;
                }
                else if (hit.transform.CompareTag("Goblin1") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("Goblin1");
                    kickAttackBool = true;
                    monster = MONSTER.GOBLIN1;
                }
                else if (hit.transform.CompareTag("Goblin2") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("Goblin2");
                    kickAttackBool = true;
                    monster = MONSTER.GOBLIN2;
                }
                else if (hit.transform.CompareTag("stage1Boss") && target.transform.CompareTag("KickAttack"))
                {
                    Debug.Log("stage1Boss");
                    kickAttackBool = true;
                    monster = MONSTER.STAGE1BOSS;
                }
                else if (hit.transform.CompareTag("Slime1") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("Slime1");
                    nastyAttackBool = true;
                    monster = MONSTER.SLIME1;
                }
                else if (hit.transform.CompareTag("Slime2") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("Slime2");
                    nastyAttackBool = true;
                    monster = MONSTER.SLIME2;
                }
                else if (hit.transform.CompareTag("Slime3") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("Slime3");
                    nastyAttackBool = true;
                    monster = MONSTER.SLIME3;
                }
                else if (hit.transform.CompareTag("Skeleton1") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("Skeleton1");
                    nastyAttackBool = true;
                    monster = MONSTER.SKELETON1;
                }
                else if (hit.transform.CompareTag("Skeleton2") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("Skeleton2");
                    nastyAttackBool = true;
                    monster = MONSTER.SKELETON2;
                }
                else if (hit.transform.CompareTag("Goblin1") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("Goblin1");
                    nastyAttackBool = true;
                    monster = MONSTER.GOBLIN1;
                }
                else if (hit.transform.CompareTag("Goblin2") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("Goblin2");
                    nastyAttackBool = true;
                    monster = MONSTER.GOBLIN2;
                }
                else if (hit.transform.CompareTag("stage1Boss") && target.transform.CompareTag("NastyAttack"))
                {
                    Debug.Log("stage1Boss");
                    nastyAttackBool = true;
                    monster = MONSTER.STAGE1BOSS;
                }
                else if (hit.transform.CompareTag("Slime1") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("Slime1");
                    shieldBreakBool = true;
                    monster = MONSTER.SLIME1;
                }
                else if (hit.transform.CompareTag("Slime2") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("Slime2");
                    shieldBreakBool = true;
                    monster = MONSTER.SLIME2;
                }
                else if (hit.transform.CompareTag("Slime3") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("Slime3");
                    shieldBreakBool = true;
                    monster = MONSTER.SLIME3;
                }
                else if (hit.transform.CompareTag("Skeleton1") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("Skeleton1");
                    shieldBreakBool = true;
                    monster = MONSTER.SKELETON1;
                }
                else if (hit.transform.CompareTag("Skeleton2") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("Skeleton2");
                    shieldBreakBool = true;
                    monster = MONSTER.SKELETON2;
                }
                else if (hit.transform.CompareTag("Goblin1") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("Goblin1");
                    shieldBreakBool = true;
                    monster = MONSTER.GOBLIN1;
                }
                else if (hit.transform.CompareTag("Goblin2") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("Goblin2");
                    shieldBreakBool = true;
                    monster = MONSTER.GOBLIN2;
                }
                else if (hit.transform.CompareTag("stage1Boss") && target.transform.CompareTag("ShiledBreak"))
                {
                    Debug.Log("stage1Boss");
                    shieldBreakBool = true;
                    monster = MONSTER.STAGE1BOSS;
                }
                else if (hit.transform.CompareTag("Slime1") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("Slime1");
                    surpriseAttackBool = true;
                    monster = MONSTER.SLIME1;
                }
                else if (hit.transform.CompareTag("Slime2") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("Slime2");
                    surpriseAttackBool = true;
                    monster = MONSTER.SLIME2;
                }
                else if (hit.transform.CompareTag("Slime3") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("Slime3");
                    surpriseAttackBool = true;
                    monster = MONSTER.SLIME3;
                }
                else if (hit.transform.CompareTag("Skeleton1") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("Skeleton1");
                    surpriseAttackBool = true;
                    monster = MONSTER.SKELETON1;
                }
                else if (hit.transform.CompareTag("Skeleton2") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("Skeleton2");
                    surpriseAttackBool = true;
                    monster = MONSTER.SKELETON2;
                }
                else if (hit.transform.CompareTag("Goblin1") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("Goblin1");
                    surpriseAttackBool = true;
                    monster = MONSTER.GOBLIN1;
                }
                else if (hit.transform.CompareTag("Goblin2") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("Goblin2");
                    surpriseAttackBool = true;
                    monster = MONSTER.GOBLIN2;
                }
                else if (hit.transform.CompareTag("stage1Boss") && target.transform.CompareTag("SurpriseAttack"))
                {
                    Debug.Log("stage1Boss");
                    surpriseAttackBool = true;
                    monster = MONSTER.STAGE1BOSS;
                }

            }
            //if (hit.transform.tag=="Untagged")
            //{ 콜라이더가 겹쳐서 사용할수 X
            //    Debug.Log(hit.transform.tag);
            //    target.transform.position = new Vector3(targetPos.x, targetPos.y, targetPos.z);
            //    // target을 원래위치로 옮겨주고
            //    target.GetComponent<Collider>().enabled = true;
            //    target = null;
            //    Debug.Log(target);
            //}
            if (attackBloodBool == false && awakenBool == false && battleJoyBool == false && boostMindBool == false
                && devilTransformBool == false && kickAttackBool == false && luckLeapBool == false && madnessBool == false
                && nastyAttackBool == false && normalAttackBool == false && normalDefenseBool == false && penetrationBool == false
                && resolveBool == false && roarAttackBool == false && shieldBreakBool == false && surpriseAttackBool == false
                && swordRecallBool == false && weaponBreakBool == false)
            {// 땅을 찍었다면
                Debug.Log("bool");
                target.transform.position = new Vector3(targetPos.x, targetPos.y, targetPos.z);
                // target을 원래위치로 옮겨주고
                target.GetComponent<Collider>().enabled = true;
                target = null;
                Debug.Log(target);
            }
            Debug.Log(target);
        }
    }
}



