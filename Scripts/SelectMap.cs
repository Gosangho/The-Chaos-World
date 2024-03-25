using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectMap : MonoBehaviour
{
    
    // Scene순서 : 오프닝 -> 맵 -> 스테이지1 -> 스테이지2 -> 스토어 -> 스테이지3 -> 스테이지4(보스)
    public void stage1()
    {
        // 초기화
        SceneManager.LoadScene(2);

    }
    public void stage2()
    {
        GameManager.Instance.currentElementalgage = 3;
        // 다음 스테이지 이동시 엘리멘탈 게이지 초기화
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
    {// 상점
        mousetarget.Instance.target = null;
        mousetarget.Instance.monster = default;
        mousetarget.Instance.targetPos = default;
        mousetarget.Instance.surpriseAttackBool = false;
        SceneManager.LoadScene(4);
    }
    
}
