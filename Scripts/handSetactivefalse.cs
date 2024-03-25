using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handSetactivefalse : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hand;
    void Start()
    {
        hand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
