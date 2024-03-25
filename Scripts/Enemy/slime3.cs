using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime3 : MonoBehaviour
{
    public static Animator Slime3Anim;
    void Start()
    {
        Slime3Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Slime3CurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.Slime3AttackBool = false;
            Destroy(gameObject);
        }
    }
}
