using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonstageBackGround : MonoBehaviour
{
    public GameObject backGround;
    float speed = 5.0f;
    public GameObject handcard;
    private void Update()
    {
        if (GameManager.Instance.Skeleton1CurrentHp <= 0 && GameManager.Instance.Skeleton2CurrentHp <= 0)

        {// ���Ͱ� ��� �׾��ٸ�
            handcard.SetActive(false);
            if (backGround.transform.position.x >= -10)
            {
                backGround.transform.position += -Vector3.right * speed * Time.deltaTime;
                // ���ڿ��¾ִϸ��̼� ������
                // Create new card ����
                Character.anim.SetBool("Player_Run_Bool", true);
            }
            else
            {
                Character.anim.SetBool("Player_Run_Bool", false);
            }

        }
    }
}
