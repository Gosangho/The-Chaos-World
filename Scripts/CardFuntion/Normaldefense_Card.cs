using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normaldefense_Card : MonoBehaviour
{
    public GameObject Cardedge;
    public int cardNumber = 10;
    public void OnMouseUp()
    {// ���� ������ 5��ŭ ���´�.
        if (GameManager.Instance.currentElementalgage >= 1)
        {
            GameManager.Instance.currentElementalgage -= 1; // ������Ż ������ -1
            GameManager.Instance.playerDefenseBuff += 5;
            GameManager.Instance.NormalDefenseBool = true;
            Destroy(gameObject); // ������Ʈ ����
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
