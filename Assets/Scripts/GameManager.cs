using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SwordMan fighter;
    SwordMan fighter1;
    SwordMan fighter2;
    SwordMan fighter3;

    Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        //fighter = new SwordMan();
        //fighter.Move();
        //fighter.hp = 200;
        //fighter.attackPower = 10;
        //fighter.Attack("�÷��̾�");

        fighter1 = new SwordMan(15, 2.5f, "���� �˻�");
        fighter2 = new SwordMan(30, 4.5f, "���� ���� �˻�");
        fighter3 = new SwordMan(55, 8.5f, "���� �� �˻�");

        //fighter1.HP = 500;
        print(fighter1.HP);

        fighter1.Move();

        fighter2.Move();

        fighter3.Move();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
