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
            {// ���ܼ���
                GameManager.Instance.Slime1CurrentDefense = 0;
            }
            GameManager.Instance.Slime1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime1CurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
            {// ���ܼ���
                GameManager.Instance.Slime2CurrentDefense = 0;
            }
            GameManager.Instance.Slime2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime2CurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
            {// ���ܼ���
                GameManager.Instance.Slime3CurrentDefense = 0;
            }
            GameManager.Instance.Slime3CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Slime3CurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
            {// ���ܼ���
                GameManager.Instance.stage1_BossCurrentDefense = 0;
            }
            GameManager.Instance.stage1_BossCurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.stage1_BossCurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
            {// ���ܼ���
                GameManager.Instance.Goblin1CurrentDefense = 0;
            }
            GameManager.Instance.Goblin1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin1CurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
            {// ���ܼ���
                GameManager.Instance.Goblin2CurrentDefense = 0;
            }
            GameManager.Instance.Goblin2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Goblin2CurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
            {// ���ܼ���
                GameManager.Instance.Skeleton1CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton1CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton1CurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
            {// ���ܼ���
                GameManager.Instance.Skeleton2CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton2CurrentHp -= (GameManager.Instance.playerAttackBuff + 3)
                - GameManager.Instance.Skeleton2CurrentDefense;
            cardDraw2();
            //+ ī�� ��ο�
            mousetarget.Instance.nastyAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ������Ż �������� 0�����϶� ���� �����Ѵٸ�
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
        {// ��尡 50�� �̻��϶�
            GameManager.Instance.Gold -= 30;
            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardList[cardNumber]);
            // ī�并ġ ����Ʈ�� ī�帮��Ʈ[cardnumber]�߰�
            Destroy(gameObject);
        }
    }

    void cardDraw2()
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
