using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openingBackground : MonoBehaviour
{
    public GameObject[] backGround;
    float speed = 1.0f;

    private void FixedUpdate()
    {
        for (int i = 0; i < backGround.Length; i++)
        {
            backGround[i].transform.position += -Vector3.right * speed * Time.deltaTime;
            if (backGround[i].transform.position.x<=-24)
            {
                backGround[i].transform.position = new Vector3(21,0.59f, 0);
            }
        }
    }
}
