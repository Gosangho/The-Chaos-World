using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class store : MonoBehaviour
{
    public GameObject AttackBlood;
    public GameObject Awaken;
    public GameObject BattleJoy;
    public GameObject BoostMind;
    public GameObject DevilTransform;
    public GameObject KickAttack;
    public GameObject LuckLeap;
    public GameObject Madness;
    public GameObject NastyAttack;
    public GameObject Penetration;
    public GameObject Resolve;
    public GameObject RoarAttack;
    public GameObject ShiledBreak;
    public GameObject SurpriseAttack;
    public GameObject SwordRecall;
    public GameObject WeaponBreak;
    public List<GameObject> storeCardList = new List<GameObject>();
    private void Awake()
    {
        storeCardList.Add(AttackBlood);
        storeCardList.Add(Awaken);
        storeCardList.Add(BattleJoy);
        storeCardList.Add(BoostMind);
        storeCardList.Add(DevilTransform);
        storeCardList.Add(KickAttack);
        storeCardList.Add(LuckLeap);
        storeCardList.Add(Madness);
        storeCardList.Add(NastyAttack);
        storeCardList.Add(Penetration);
        storeCardList.Add(Resolve);
        storeCardList.Add(RoarAttack);
        storeCardList.Add(ShiledBreak);
        storeCardList.Add(SurpriseAttack);
        storeCardList.Add(SwordRecall);
        storeCardList.Add(WeaponBreak);
    }
    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            int ran = Random.Range(0, storeCardList.Count);
            GameObject obj = Instantiate(storeCardList[ran]);
            //obj.transform.parent = GameObject.Find("Content").transform;
            obj.transform.SetParent(GameObject.Find("Content").transform);
            obj.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
