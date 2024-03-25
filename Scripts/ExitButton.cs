using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public GameObject targetUI;
    public GameObject targethandobj;
    Button button;
    public ActiveButton ActiveButton;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => targetUI.SetActive(!targetUI.activeSelf));
        button.onClick.AddListener(cardDestroy);
        button.onClick.AddListener(handobjOn);
    }
    void handobjOn()
    {
        targethandobj.SetActive(!targethandobj.activeSelf);
    }
    public void cardDestroy()
    {
        for (int i = 0; i < ActiveButton.cardGraveCreate.Count; i++)
        {
            Destroy(ActiveButton.cardGraveCreate[i]);
        }
        ActiveButton.cardGraveCreate.Clear();
    }

}
