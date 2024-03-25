using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1Boss : MonoBehaviour
{
    public static Animator Stage1BossAnim;
    void Start()
    {
        Stage1BossAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (GameManager.Instance.stage1_BossCurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.stage1_BossAttackBool = false;
            Destroy(gameObject);
        }
    }
}
