using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton2 : MonoBehaviour
{
    public static Animator Skeleton2Anim;
    void Start()
    {
        Skeleton2Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Skeleton2CurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.Skeleton2AttackBool = false;
            Destroy(gameObject);
        }
    }
}
