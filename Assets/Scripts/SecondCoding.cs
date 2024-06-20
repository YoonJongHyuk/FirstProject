using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 30;
    public int age2 = 7;
    public bool isMan = true;
    public bool runState = true;
    public bool walkState = true;

    public int numbers = 0;
    int sum = 0;

    public int endCunt = 0;
    int num = 0;


    void Start()
    {


        //#region 10대
        //if (age1 < 20)
        //{
        //    print("age1은 10대입니다.");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1은 20대입니다.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1은 30대입니다.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1은 40대입니다.");
        //}
        //else {
        //    print("age1의 나이는 50대 이상입니다.");
        //}
        //#endregion

        //#region Example 2
        ////
        //if (isMan == false && age1 >= 20)
        //{
        //    print("성인 여성입니다.");
        //}
        //else
        //{
        //    print("미성년자이거나, 남성입니다.");
        //}


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

        //if (!runState || walkState)
        //{
        //    print("이동 중입니다.");
        //}
        //else
        //{
        //    print("정지한 상태입니다.");
        //}
        //#endregion

        // 반복문
        // for( 시작 변수 선언및 초기화; 종료 조건식; 증감식)
        //{
        //      반복해서 수행할 내용
        //}

        // 1부터 10까지 모든 정수를 출력한다.
        //for (int i = 0; i < 10; i++)
        //{
        //    print(i + 1);
        //}

        //for (int i = 0; i < numbers; i++)
        //{
        //    int number = i + 1;
        //    if (number % 2 == 0)
        //    {
        //        print(number);
        //    }
        //}

        // 0부터 endCunt 전까지 짝수만 출력한다. 그런데 출력된 짝수의 수가 10개에 도달하면 반복을 종료한다.
        //for (int i = 0; i < endCunt; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        print(i);
        //        num++;
        //        if (num >= 10) break;
        //    }
        //}

        //for (int i = 2; i < 10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        print(i.ToString() + " x " + j.ToString() + "= " + (i * j).ToString());
        //    }
        //}


        //for (int i = 0; i < 5; i++)
        //{
        //    print(star);
        //    star += "*";
        //}

        //for(int i = 1; i <= 5; i++)
        //{
        //    print(new string('*', i));
        //}
        #region 피라미드 찍기
        //string star = "";
        //for (int i = 0; i < 5; i++)
        //{
        //    
        //    for (int j = 0; j < i + 1; j++)
        //    {
        //        star += "*";
        //    }
        //    star += "\n";
        //}
        //print(star);
        #endregion 

        //Debug.Log("Hello World!");
        //Debug.LogWarning("Hello World!");
        //Debug.LogError("Hello World!");


    }
    //string star = "*";
    //public int starNum = 0;
}
