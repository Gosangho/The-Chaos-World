using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin2 : MonoBehaviour
{
    public static Animator Goblin2Anim;
    void Start()
    {
        Goblin2Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Goblin2CurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.Goblin2AttackBool = false;
            Destroy(gameObject);
        }   
    }
}
