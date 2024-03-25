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
        turnText = GetComponent<TextMeshProUGUI>(); // ĳ��
        cardHandInstance();
    }
    public void cardHandInstance()
    {
        float j = -8f; // ī���� ���� ù��° �ڸ���(X��)
        
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
    {// �� ���� ��ư�� ������� ����
        GameManager.Instance.GameTurn++; // Ŭ���ϸ� ���� ����
        GameManager.Instance.currentElementalgage = 3;
        cardDestroy();
        // 1�Ͽ��� ������ CardHand(clone)�� ����

        ResetSystem();
        // 1�Ͽ��� ���� 5���� ī�带 cardGrave�������� �߰����ְ�

        turnCard();
        // cardGrave���� 5���� cardHand�� �־���
        enemyAttackBool(); // enemy�� attackBool=true
        
        if (SceneManager.GetActiveScene().buildIndex==2)// ������ ��������
        {// ������ ��ư�� �������� 2�� ���̶��(���Ͱ� �÷��̾�� ������� �ִ� �κ�)
            if (GameManager.Instance.Slime1AttackBool&&GameManager.Instance.Slime1CurrentHp>0)
            {// ������ 1

                slime1.Slime1Anim.SetTrigger("Slime1_Attack_Triger");// ������ ���ݸ��
                Character.anim.SetTrigger("Player_Hit_Triger"); // �÷��̾ �ǰݴ��ϴ� �ִϸ��̼�
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool�� Ʈ����
                    GameManager.Instance.Slime1CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration�� Ʈ����
                    GameManager.Instance.Slime1CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff<0)
                {// ���潺 ������ �������
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff>=GameManager.Instance.Slime1CurrentAttack)
                {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
                    // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Slime1CurrentAttack;
                    // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                    // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                    // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                    // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
                }
                else
                {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Slime1CurrentAttack - 
                        (GameManager.Instance.playerDefenseBuff);
                    // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                    // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
                }
                
                GameManager.Instance.Slime1AttackBool = false;
                if (GameManager.Instance.Slime1AttackBool==false&&GameManager.Instance.PenetrationBool==false)
                {
                    GameManager.Instance.Slime1CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Slime2AttackBool&&GameManager.Instance.Slime2CurrentHp>0)
            {// ������ 2
                slime2.Slime2Anim.SetTrigger("Slime2_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool�� Ʈ����
                    GameManager.Instance.Slime2CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration�� Ʈ����
                    GameManager.Instance.Slime2CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// ���潺 ������ �������
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Slime2CurrentAttack)
                {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
                    // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Slime2CurrentAttack;
                    // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                    // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                    // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                    // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
                }
                else
                {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Slime2CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                    // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
                }

                GameManager.Instance.Slime2AttackBool = false;
                if (GameManager.Instance.Slime2AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Slime2CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Slime3AttackBool && GameManager.Instance.Slime3CurrentHp > 0)
            {// ������ 3
                slime3.Slime3Anim.SetTrigger("Slime3_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool�� Ʈ����
                    GameManager.Instance.Slime3CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration�� Ʈ����
                    GameManager.Instance.Slime3CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// ���潺 ������ �������
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Slime3CurrentAttack)
                {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
                    // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Slime3CurrentAttack;
                    // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                    // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                    // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                    // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
                }
                else
                {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Slime3CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                    // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
                }
                
                GameManager.Instance.Slime3AttackBool = false;
                if (GameManager.Instance.Slime3AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Slime3CurrentAttack = 2;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex==3)// ��� ��������
        {
            if (GameManager.Instance.Goblin1AttackBool&&GameManager.Instance.Goblin1CurrentHp>0)
            {// ��� 1
                Goblin1.Goblin1Anim.SetTrigger("Goblin1_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool�� Ʈ����
                    GameManager.Instance.Goblin1CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration�� Ʈ����
                    GameManager.Instance.Goblin1CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// ���潺 ������ �������
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Goblin1CurrentAttack)
                {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
                    // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Goblin1CurrentAttack;
                    // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                    // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                    // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                    // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
                }
                else
                {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Goblin1CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                    // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
                }

                GameManager.Instance.Goblin1AttackBool = false;
                if (GameManager.Instance.Goblin1AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Goblin1CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Goblin2AttackBool && GameManager.Instance.Goblin2CurrentHp > 0)
            {// ��� 2
                Goblin2.Goblin2Anim.SetTrigger("Goblin2_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");
                if (GameManager.Instance.AwakenBool)
                {// AwakenBool�� Ʈ����
                    GameManager.Instance.Goblin2CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration�� Ʈ����
                    GameManager.Instance.Goblin2CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }


                if (GameManager.Instance.playerDefenseBuff < 0)
                {// ���潺 ������ �������
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Goblin2CurrentAttack)
                {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
                    // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Goblin2CurrentAttack;
                    // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                    // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                    // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                    // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
                }
                else
                {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Goblin2CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                    // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
                }

                GameManager.Instance.Goblin2AttackBool = false;
                if (GameManager.Instance.Goblin2AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Goblin2CurrentAttack = 2;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex==5)// ���̷��� ��������
        {
            if (GameManager.Instance.Skeleton1AttackBool&&GameManager.Instance.Skeleton1CurrentHp>0)
            {// ���̷��� 1
                Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");

                if (GameManager.Instance.AwakenBool)
                {// AwakenBool�� Ʈ����
                    GameManager.Instance.Skeleton1CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration�� Ʈ����
                    GameManager.Instance.Skeleton1CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// ���潺 ������ �������
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Skeleton1CurrentAttack)
                {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
                    // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Skeleton1CurrentAttack;
                    // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                    // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                    // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                    // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
                }
                else
                {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Skeleton1CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                    // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
                }

                GameManager.Instance.Skeleton1AttackBool = false;
                if (GameManager.Instance.Skeleton1AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Skeleton1CurrentAttack = 2;
                }
            }

            if (GameManager.Instance.Skeleton2AttackBool && GameManager.Instance.Skeleton2CurrentHp > 0)
            {// ���̷��� 2
                Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Attack_Triger");
                Character.anim.SetTrigger("Player_Hit_Triger");

                if (GameManager.Instance.AwakenBool)
                {// AwakenBool�� Ʈ����
                    GameManager.Instance.Skeleton2CurrentAttack = 0;
                }

                if (GameManager.Instance.PenetrationBool)
                {// penetration�� Ʈ����
                    GameManager.Instance.Skeleton2CurrentAttack = 0;
                    GameManager.Instance.PenetrationBool = false;
                }

                if (GameManager.Instance.playerDefenseBuff < 0)
                {// ���潺 ������ �������
                    GameManager.Instance.playerDefenseBuff = 0;
                }

                if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.Skeleton2CurrentAttack)
                {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
                    // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                    GameManager.Instance.playerDefenseBuff -= GameManager.Instance.Skeleton2CurrentAttack;
                    // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                    // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                    // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                    // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
                }
                else
                {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                    GameManager.Instance.playerCurrentHp -= GameManager.Instance.Skeleton2CurrentAttack -
                        (GameManager.Instance.playerDefenseBuff);
                    // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                    // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
                }

                GameManager.Instance.Skeleton2AttackBool = false;
                if (GameManager.Instance.Skeleton2AttackBool == false && GameManager.Instance.PenetrationBool == false)
                {
                    GameManager.Instance.Skeleton2CurrentAttack = 2;
                }
            }
        }

        if (SceneManager.GetActiveScene().buildIndex==6)// ���� ��������
        {
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Attack_Triger");
            Character.anim.SetTrigger("Player_Hit_Triger");

            if (GameManager.Instance.AwakenBool)
            {// AwakenBool�� Ʈ����
                GameManager.Instance.stage1_BossCurrentAttack = 0;
            }

            if (GameManager.Instance.PenetrationBool)
            {// penetration�� Ʈ����
                GameManager.Instance.stage1_BossCurrentAttack = 0;
                GameManager.Instance.PenetrationBool = false;
            }

            if (GameManager.Instance.playerDefenseBuff < 0)
            {// ���潺 ������ �������
                GameManager.Instance.playerDefenseBuff = 0;
            }

            if (GameManager.Instance.playerDefenseBuff >= GameManager.Instance.stage1_BossCurrentAttack)
            {// �÷��̾��� ���¹����� ������1�� ���ݷº��� ũ�ų� ���ٸ�
             // �÷��̾��� ���¹����� 5 ������1�� ���ݷ� 2
                GameManager.Instance.playerDefenseBuff -= GameManager.Instance.stage1_BossCurrentAttack;
                // �÷��̾��� ���潺������ ������1�� ���ݷ¸�ŭ ���̳ʽ�
                // ������ ���ϰ� �������� ������1�� ���ݸ��(�ִϸ��̼�)�� ��������ϰ�
                // �÷��̾��� ���¹����� ��ġȭ�ؼ� ������1�� �����������
                // �÷��̾��� ���¹��� ��ġ�� �پ��� ���� ��ġȭ + ����Ʈ �߰�
            }
            else
            {// �������� ���ݷ��� �÷��̾��� ���� �������� ũ�ٸ�
                GameManager.Instance.playerCurrentHp -= GameManager.Instance.stage1_BossCurrentAttack -
                    (GameManager.Instance.playerDefenseBuff);
                // �������� ���ݷ¿��� �÷��̾��� ���¼�ġ��ŭ ���ش���
                // �� �������ŭ �÷��̾��� ü�¼�ġ�� ���ش�.
            }

            GameManager.Instance.stage1_BossAttackBool = false;
            if (GameManager.Instance.stage1_BossAttackBool == false && GameManager.Instance.PenetrationBool == false)
            {
                GameManager.Instance.stage1_BossCurrentAttack = 2;
            }

        }
        // ���ǰ��� ��(false -> true -> �� ���� -> enemyAttack=false -> ���� ����)

        // ���� ������ ������ �� ����
        // �÷��̾���(¦����), ������(Ȧ����)
        // �÷��̾���(0)-> ������(��++) -> ������(1)�÷��̾� ���� -> ������(��++) -> �÷��̾���(2) 
        PlayerBuffReset(); // ���� ������ �ʱ�ȭ
        createNewCard();
        // cardHand�� �ٽ� Instante����
    }
    public void DevilTransform()
    {
        if (GameManager.Instance.DevilTransform)
        {// �Ǹ��������� true���¶��
            GameManager.Instance.playerCurrentHp = GameManager.Instance.playerCurrentHp - 20;
        }
        // ���� ���� �׾��ٸ� Reset
    }
    void ResetSystem()
    {
        for (int i = 0; i < GameManager.Instance.cardHand.Count; i++)
        {// 0 1 2 3 4
            Debug.Log(GameManager.Instance.cardHand.Count);

            GameManager.Instance.cardGrave.Add(GameManager.Instance.cardHand[i]);
            // �� ����� cardHand�� �ִ� List���� cardGrave�� �߰�
            Debug.Log(GameManager.Instance.cardGrave.Count);
        }
        GameManager.Instance.cardHand.Clear();
        // cardHand����Ʈ Ŭ����
    }
    void turnCard()
    {
        for (int i = 0; i < 5; i++)
        {
            GameManager.Instance.cardHand.Add(GameManager.Instance.cardGrave[0]);
            // cardGrave[0]~cardGrave[4] ������� ? �ƴ��ٵ�
            // cardHand����Ʈ�� cardGrave����Ʈ�� ���������ִ� 5���� �־��ش�.
            GameManager.Instance.cardGrave.RemoveAt(0);
            // cardHand����Ʈ�� ���� ī��� cardGrave����Ʈ���� �����ش�.
        }
    }
    float j = -8f; // ī���� ���� ù��° �ڸ���(X��)
    void createNewCard()
    {
        for (int i = 0; i < 5; i++)
        {// cardHand.count��ŭ ī�� ����
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
            // 1�Ͽ� Create�� Ŭ�� ī���
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
        {// GameTurn�� AwakenTurn(2�ϰ� ȿ������)�� ������ 2�� ���´ٸ�(Awakenī��ȿ���κ�)
            GameManager.Instance.AwakenBool = false;
            GameManager.Instance.Slime1CurrentAttack = 2;
            GameManager.Instance.Slime2CurrentAttack = 2;
            GameManager.Instance.Slime3CurrentAttack = 2;
            GameManager.Instance.Goblin1CurrentAttack = 2;
            GameManager.Instance.Goblin2CurrentAttack = 2;
            GameManager.Instance.Skeleton1CurrentAttack = 2;
            GameManager.Instance.Skeleton2CurrentAttack = 2;
            GameManager.Instance.stage1_BossCurrentAttack = 2;
            // �����ũ�� 2���� ��������� ������ ���ݷ� ��ġ �ʱ�ȭ
            // ȿ������
        }

        if (GameManager.Instance.GameTurn-GameManager.Instance.MadnessTurnBuffer==2)
        {// 2���� �����ٸ�
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
        GameManager.Instance.playerDefenseBuff = 0; // 1�ϰ� ���ӵǴ� �÷��̾� ����ġ �ʱ�ȭ
        
    // ���潺 ��ġ �ʱ�ȭ(1�ϰ� ���ӵǴ�)
    }
}
