using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageBackGroundMove : MonoBehaviour
{
    public GameObject backGround;
    float speed = 5.0f;
    public GameObject handcard;
    private void Update()
    {
        if (GameManager.Instance.Slime1CurrentHp<=0&&GameManager.Instance.Slime2CurrentHp<=0&&
            GameManager.Instance.Slime3CurrentHp<=0)
        {// 몬스터가 모두 죽었다면
             handcard.SetActive(false);
             if (backGround.transform.position.x >= -10)
             {
                 backGround.transform.position += -Vector3.right * speed * Time.deltaTime;
                 Character.anim.SetBool("Player_Run_Bool",true);
                 // 상자여는애니메이션 나오고
                 // Create new card 생성
             }
            else
            {
                Character.anim.SetBool("Player_Run_Bool", false);
            }

        }
    }
}
