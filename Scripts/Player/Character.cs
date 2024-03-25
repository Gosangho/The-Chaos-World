using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;



public class Character : MonoBehaviour
{
    public Image Hpimage;
    public Text MaxHpText;
    public Text CurrentHpText;
    public static Animator anim;
    readonly int PlayerDeath = Animator.StringToHash("Death");

    void Start()
    {
        Hpimage = GetComponent<Image>();
        MaxHpText = GetComponent<Text>();
        CurrentHpText = GetComponent<Text>();
        anim = GetComponent<Animator>();
        
        //action.GetObjectData(Character);
        
        //cardList[1].SetActive(false);
        // �̷��������� ����
        // 1.���� ī��� SetActive(true)
        // 2.����� ī��� ī����̷� �̵�
        // 3.����ִ� ī��� ī����̿� �ִ� ī��� �з�
        // 4.�� ���۽� ī�� 3�� ��ο�
    }

    void Update()
    {
        DevilTransformReset();
        GameOver();
    }

    void DevilTransformReset()
    {
        if (GameManager.Instance.enemyCurrentHp <= 0)
        {// ���� Hp�� 0 ���϶��
            GameManager.Instance.DevilTransform = false;
        }
    }
    
    void GameOver()
    {
        if (GameManager.Instance.playerCurrentHp<=0)
        {
            anim.SetTrigger("Player_Death_Triger");
            Invoke("LoadScene", 3f);
            
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);

    }
}
