using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveButton : MonoBehaviour
{
    public Button cardButton;
    public GameObject targetBackGroundImage;
    public GameObject targetHandobj;
    public List<GameObject> cardGraveCreate = new List<GameObject>();
    void Start()
    {
        cardButton = GetComponent<Button>();
        cardButton.onClick.AddListener(cardCreate);
        cardButton.onClick.AddListener(cardBook);
        cardButton.onClick.AddListener(handObj);
    }

    public void cardBook()
    {
        targetBackGroundImage.SetActive(!targetBackGroundImage.activeSelf);
    }
    public void handObj()
    {
        targetHandobj.SetActive(!targetHandobj.activeSelf);
    }
    public void cardCreate()
    {
        float width=0f;
        float height = 2.0f;
        for (int i = 0; i < GameManager.Instance.cardGrave.Count; i++)
        {
            GameObject Obj = Instantiate(GameManager.Instance.cardGrave[i], new Vector3(-4.61f+width, height, 0), Quaternion.identity);
            width += 2.9f;
            if (Obj.transform.position.x>=4.09)
            {
                width = 0f;
                height = -2.0f;
            }
            cardGraveCreate.Add(Obj);
            
        }
        width = 0f;
    }
}
