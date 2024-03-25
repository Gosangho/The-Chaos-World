using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class storeout : MonoBehaviour
{
    public TextMeshProUGUI storeOutButton;
    void Start()
    {
        storeOutButton = GetComponent<TextMeshProUGUI>();
    }

    public void StoreOut()
    {
        SceneManager.LoadScene(1);
    }
}
