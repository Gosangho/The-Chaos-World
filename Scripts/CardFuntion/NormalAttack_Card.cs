using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 9;

    private void Update()
    {
        if (mousetarget.Instance.normalAttackBool)
        {
            switch (mousetarget.Instance.monster)
            {
                case MONSTER.SLIME1:
                    Slime1NormalAttack();
                    Debug.Log("switchSlime1NolmalAttack");
                    break;
                case MONSTER.SLIME2:
                    Slime2NormalAttack();
                    Debug.Log("switchSlime2NolmalAttack");
                    break;
                case MONSTER.SLIME3:
                    Slime3NormalAttack();
                    Debug.Log("switchSlime3NolmalAttack");
                    break;
                case MONSTER.STAGE1BOSS:
                    stage1BossNormalAttack();
                    Debug.Log("switchBossNolmalAttack");
                    break;
                case MONSTER.GOBLIN1:
                    Goblin1NormalAttack();
                    Debug.Log("switchGoblin1NolmalAttack");
                    break;
                case MONSTER.GOBLIN2:
                    Goblin2NormalAttack();
                    Debug.Log("switchGoblin2NolmalAttack");
                    break;
                case MONSTER.SKELETON1:
                    Skeleton1NormalAttack();
                    Debug.Log("switchskeleton1NolmalAttack");
                    break;
                case MONSTER.SKELETON2:
                    Skeleton2NormalAttack();
                    Debug.Log("switchskeleton2NolmalAttack");
                    break;
                default:
                    Debug.Log("switchdefault");
                    break;
            }
        }
    }
    void Slime1NormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime1.Slime1Anim.SetTrigger("Slime1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.Slime1CurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.Slime1CurrentDefense = 0;
            }

            GameManager.Instance.Slime1CurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.Slime1CurrentDefense;
            Debug.Log(GameManager.Instance.Slime1CurrentDefense);
            Debug.Log(GameManager.Instance.playerAttackBuff);
            
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime2NormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime2.Slime2Anim.SetTrigger("Slime2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.Slime2CurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.Slime2CurrentDefense = 0;
            }
            GameManager.Instance.Slime2CurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.Slime2CurrentDefense;

            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage<=0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Slime3NormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            slime3.Slime3Anim.SetTrigger("Slime3_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.Slime3CurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.Slime3CurrentDefense = 0;
            }
            GameManager.Instance.Slime3CurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.Slime3CurrentDefense;

            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void stage1BossNormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            stage1Boss.Stage1BossAnim.SetTrigger("Stage1Boss_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.stage1_BossCurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.stage1_BossCurrentDefense = 0;
            }
            GameManager.Instance.stage1_BossCurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.stage1_BossCurrentDefense;

            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin1NormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin1.Goblin1Anim.SetTrigger("Goblin1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.Goblin1CurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.Goblin1CurrentDefense = 0;
            }
            GameManager.Instance.Goblin1CurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.Goblin1CurrentDefense;

            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Goblin2NormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Goblin2.Goblin2Anim.SetTrigger("Goblin2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.Goblin2CurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.Goblin2CurrentDefense = 0;
            }
            GameManager.Instance.Goblin2CurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.Goblin2CurrentDefense;

            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton1NormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton1.Skeleton1Anim.SetTrigger("Skeleton1_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.Skeleton1CurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.Skeleton1CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton1CurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.Skeleton1CurrentDefense;

            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    void Skeleton2NormalAttack()
    {
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            Character.anim.SetTrigger("Player_Attack_Triger");
            Skeleton2.Skeleton2Anim.SetTrigger("Skeleton2_Hit_Triger");
            GameManager.Instance.currentElementalgage -= 1; // ¿¤¸®¸àÅ» °ÔÀÌÁö -1
            if (GameManager.Instance.Skeleton2CurrentDefense < 0)
            {// ¿¹¿Ü¼³Á¤
                GameManager.Instance.Skeleton2CurrentDefense = 0;
            }
            GameManager.Instance.Skeleton2CurrentHp -= (GameManager.Instance.playerAttackBuff + 5)
                - GameManager.Instance.Skeleton2CurrentDefense;

            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            Destroy(mousetarget.Instance.target.gameObject);
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }

        if (GameManager.Instance.currentElementalgage <= 0)
        {// ¿¤¸®¸àÅ» °ÔÀÌÁö°¡ 0ÀÌÇÏÀÏ¶§ ÀûÀ» °ø°ÝÇÑ´Ù¸é
            mousetarget.Instance.target.GetComponent<Collider>().enabled = true;
            mousetarget.Instance.normalAttackBool = false;
            mousetarget.Instance.monster = default;
            mousetarget.Instance.target.transform.position = mousetarget.Instance.targetPos;
            mousetarget.Instance.target = null;
            mousetarget.Instance.targetPos = default;
        }
    }
    public void OnMouseEnter()
    {
        Cardedge.SetActive(true);
    }

    public void OnMouseExit()
    {
        Cardedge.SetActive(false);
    }
}
