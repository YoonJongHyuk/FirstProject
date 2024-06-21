using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    private int hp = 100;
    public float attackPower = 5.5f;
    public string myName = "검객";

    public int HP
    {
        get
        {
            return hp;
        }
        //set
        //{
        //    hp = value;
        //}
    }

    public SwordMan(int health, float atk, string nickName)
    {
        hp = health;
        attackPower = atk;
        myName = nickName;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        print(myName + "(이)가 이동한다.");
    }

    public float Attack(string targetName)
    {
        print(targetName + "에게 " + attackPower.ToString() + "만큼 피해를 입힙니다.");
        return attackPower;
    }

    public void Die()
    {
        print("죽었습니다.");
    }

}
