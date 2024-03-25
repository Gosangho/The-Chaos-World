using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickAttack_Draw_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 5;
    private void Update()
    {
        if (mousetarget.Instance.kickAttackBool)
        {
            switch (mousetarget.Instance.monster)
            {
                case MONSTER.SLIME1:
                    Slime1KickAttack();
                    Debug.Log("switchSlime1kickAttack");
                    break;
                case MONSTER.SLIME2:
                    Slime2KickAttack();
                    Debug.Log("switchSlime2kickAttack");
                    break;
                case MONSTER.SLIME3:
                    Slime3KickAttack();
                    Debug.Log("switchSlime3kickAttack");
                    break;
                case MONSTER.STAGE1BOSS:
                    Stage1BossKickAttack();
                    Debug.Log("switchBosskickAttack");
                    break;
                case MONSTER.GOBLIN1:
                    Goblin1KickAttack();
                    Debug.Log("switchGoblin1kickAttack");
                    break;
                case MONSTER.GOBLIN2:
                    Goblin2KickAttack();
                    Debug.Log("switchGoblin2kickAttack");
                    break;
                case MONSTER.SKELETON1:
                    Skeleton1KickAttack();
                    Debug.Log("switchSkeleton1kickAttack");
                    break;
                case MONSTER.SKELETON2:
                    Skeleton2KickAttack();
                    Debug.Log("switchSkeleton2kickAttack");
                    break;
                default:
                    Debug.Log("switchdefault");
                    break;
            }
        }
    }
    void Slime1KickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime1.Slime1Anim.SetTrigger("Slime1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime1CurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.Slime1CurrentDefense = 0;
            }
            GameManager.Instance.Slime1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime1CurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime2KickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime2.Slime2Anim.SetTrigger("Slime2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime2CurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.Slime2CurrentDefense = 0;
            }
            GameManager.Instance.Slime2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime2CurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime3KickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime3.Slime3Anim.SetTrigger("Slime3_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Slime3CurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.Slime3CurrentDefense = 0;
            }
            GameManager.Instance.Slime3CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime3CurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Stage1BossKickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Hit_Triger");

            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.stage1_BossCurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.stage1_BossCurrentDefense = 0;
            }
            GameManager.Instance.stage1_BossCurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.stage1_BossCurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin1KickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin1.Goblin1Anim.SetTrigger("Goblin1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Goblin1CurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.Goblin1CurrentDefense = 0;
            }
            GameManager.Instance.Goblin1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin1CurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin2KickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin2.Goblin2Anim.SetTrigger("Goblin2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Goblin2CurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.Goblin2CurrentDefense = 0;
            }
            GameManager.Instance.Goblin2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin2CurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton1KickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Skeleton1CurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.Skeleton1CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton1CurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton2KickAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1;
            if (GameManager.Instance.Skeleton2CurrentDefense < 0)
            {// ���ܼ���
                GameManager.Instance.Skeleton2CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton2CurrentDefense;
            cardDraw();
            //+ ī�� ��ο�
            mousetarget.Instance.kickAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.kickAttackBool = false;
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
        {// ��尡 50�� �̻��϶�
            GameManager.Instance.Gold -= 30;
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // ī�并ġ ����Ʈ�� ī�帮��Ʈ[cardnumber]�߰�
            Destroy(gameObject);
        }
    }
    void cardDraw()
    {
        GameObject obj = Instantiate(GameManager.Instance.cardGrave[0],
                new Vector3(mousetarget.Instance.targetPos.x, mousetarget.Instance.targetPos.y, 0), Quaternion.identity);
        // ī�幫��[0]���� ī�� �ν��Ͻ�
        // ī�幫��[0]��° ī�� ī���ڵ帮��Ʈ�� �߰� -> 
        // ��Ʋ����ī�� ����������
        //
        GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
        // ī�� ���������� ������
        GameManager.Instance.cardHand.Remove(GameManager.Instance.cardList[cardNumber]);
        // ī���ڵ忡 �ִ� ��ο�ī�尡 cardHand����Ʈ���� ��������,
        GameManager.Instance.cardHand.Add(GameManager.Instance.cardGrave[0]);
        // ������ ù���� ī�尡 Hand�� �߰��ǰ�
        GameManager.Instance.cardGrave.RemoveAt(0);
        // Hand�� �߰��� ī�尡 �����ӿ��� �����
        GameObject hand = GameObject.Find("Hand");
        if (hand)
        {
            obj.transform.parent = hand.transform;
        }
        GameManager.Instance.createCardHand.Add(obj);
    }
}
