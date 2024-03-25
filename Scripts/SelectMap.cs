using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectMap : MonoBehaviour
{
    
    // Scene���� : ������ -> �� -> ��������1 -> ��������2 -> ����� -> ��������3 -> ��������4(����)
    public void stage1()
    {
        // �ʱ�ȭ
        SceneManager.LoadScene(2);

    }
    public void stage2()
    {
        GameManager.Instance.currentElementalgage = 3;
        // ���� �������� �̵��� ������Ż ������ �ʱ�ȭ
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        SceneManager.LoadScene(3);
    }
    public void stage3()
    {
        GameManager.Instance.currentElementalgage = 3;
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        SceneManager.LoadScene(5);
    }
    public void stage4()
    {
        GameManager.Instance.currentElementalgage = 3;
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        SceneManager.LoadScene(6);
    }
    public void store()
    {// ����
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        SceneManager.LoadScene(4);
    }
    
}
