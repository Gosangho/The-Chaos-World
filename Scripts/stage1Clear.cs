using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1Clear : MonoBehaviour
{
    public GameObject backGround;
    float speed = 5.0f;
    public GameObject handcard;
    private void Update()
    {
        if (GameManager.Instance.stage1_BossCurrentHp <= 0)
        {// ���Ͱ� ��� �׾��ٸ�
            handcard.SetActive(false);
            if (backGround.transform.position.x >= -10)
            {
                backGround.transform.position += -Vector3.right * speed * Time.deltaTime;
                // ���ڿ��¾ִϸ��̼� ������
                // Create new card ����
            }

        }
    }
}
