using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin1 : MonoBehaviour
{
    public static Animator Goblin1Anim;
    void Start()
    {
        Goblin1Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Goblin1CurrentHp<=0)
        {
            GameManager.Instance.Gold += 5;
            GameManager.Instance.Goblin1AttackBool = false;
            Destroy(gameObject);
        }
    }
}
