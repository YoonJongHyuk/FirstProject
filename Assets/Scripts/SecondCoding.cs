using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 30;
    public int age2 = 7;
    public bool isMan = true;
    public bool runState = true;
    public bool walkState = true;



    void Start()
    {


        #region 10��
        if (age1 < 20)
        {
            print("age1�� 10���Դϴ�.");
        }
        else if (age1 < 30)
        {
            print("age1�� 20���Դϴ�.");
        }
        else if (age1 < 40)
        {
            print("age1�� 30���Դϴ�.");
        }
        else if (age1 < 50)
        {
            print("age1�� 40���Դϴ�.");
        }
        else {
            print("age1�� ���̴� 50�� �̻��Դϴ�.");
        }
        #endregion

        #region Example 2
        //
        if (isMan == false && age1 >= 20)
        {
            print("���� �����Դϴ�.");
        }
        else
        {
            print("�̼������̰ų�, �����Դϴ�.");
        }
        #endregion

        //#region 
        //if (runState == true || walkState == true)
        //{
        //    print("�̵� ���Դϴ�.");
        //}
        //else
        //{
        //    print("������ �����Դϴ�.");
        //}
        //#endregion

        // if(runState == true)
        //if (runState)

        // if(runState == false)
        //if (!runState)

        if (!runState || walkState)
        {
            print("�̵� ���Դϴ�.");
        }
        else
        {
            print("������ �����Դϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
