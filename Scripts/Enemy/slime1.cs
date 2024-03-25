using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime1 : MonoBehaviour
{
    public static Animator Slime1Anim;
    void Start()
    {
        Slime1Anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Slime1CurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.Slime1AttackBool = false;
            Destroy(gameObject);
        }
    }
}
