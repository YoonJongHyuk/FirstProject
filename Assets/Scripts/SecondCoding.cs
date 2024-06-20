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


        #region 10대
        if (age1 < 20)
        {
            print("age1은 10대입니다.");
        }
        else if (age1 < 30)
        {
            print("age1은 20대입니다.");
        }
        else if (age1 < 40)
        {
            print("age1은 30대입니다.");
        }
        else if (age1 < 50)
        {
            print("age1은 40대입니다.");
        }
        else {
            print("age1의 나이는 50대 이상입니다.");
        }
        #endregion

        #region Example 2
        //
        if (isMan == false && age1 >= 20)
        {
            print("성인 여성입니다.");
        }
        else
        {
            print("미성년자이거나, 남성입니다.");
        }
        #endregion

        //#region 
        //if (runState == true || walkState == true)
        //{
        //    print("이동 중입니다.");
        //}
        //else
        //{
        //    print("정지한 상태입니다.");
        //}
        //#endregion

        // if(runState == true)
        //if (runState)

        // if(runState == false)
        //if (!runState)

        if (!runState || walkState)
        {
            print("이동 중입니다.");
        }
        else
        {
            print("정지한 상태입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
