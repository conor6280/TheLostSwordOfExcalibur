using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDrop : MonoBehaviour
{
   public MonsterType[] type;
    bool isDead;
    public GameObject[] weapons;
    GameObject clone;
    public bool[] deathtype;
     public int characterNum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            for (int i = 0; i >= type.Length; i++)
            {
                if (type)
                {
                   clone = Instantiate(weapons[i], transform.position, Quaternion.identity) as GameObject;
                }
            }


        }
    }


    public enum MonsterType
    {
        chicken,
        slime,
        goblin,
        orge,
        troll,
        golem,
        elementalF,
        elementalW,
        elementalI,

    }
}
