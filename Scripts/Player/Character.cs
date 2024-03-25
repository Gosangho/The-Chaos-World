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
        // 이런느낌으로 관리
        // 1.가진 카드는 SetActive(true)
        // 2.사용한 카드는 카드더미로 이동
        // 3.들고있는 카드와 카드더미에 있는 카드로 분류
        // 4.턴 시작시 카드 3장 드로우
    }

    void Update()
    {
        DevilTransformReset();
        GameOver();
    }

    void DevilTransformReset()
    {
        if (GameManager.Instance.enemyCurrentHp <= 0)
        {// 적의 Hp가 0 이하라면
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
