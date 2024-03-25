using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime2 : MonoBehaviour
{
    public static Animator Slime2Anim;
    void Start()
    {
        Slime2Anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Slime2CurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.Slime2AttackBool = false;
            Destroy(gameObject);
        }
    }
}
