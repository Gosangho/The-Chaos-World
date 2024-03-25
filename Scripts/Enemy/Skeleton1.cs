using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton1 : MonoBehaviour
{
    public static Animator Skeleton1Anim;
    void Start()
    {
        Skeleton1Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Skeleton1CurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.Skeleton1AttackBool = false;
            Destroy(gameObject);
        }
    }
}
