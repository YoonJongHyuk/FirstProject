using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 첫 코딩 수업용 코드이다.
/// </summary>
public class FirstCoding : MonoBehaviour
{
    // 정수형 변수 선언하기
    public int numberInt1 = 5;
    public int numberInt2 = 3;


    int numberSum;
    int numSubtract;
    int numMultiply;
    int numDivide;



    int numberRemainder;

    // 실수형 변수 선언하기
    //public float numberFloat1;
    //public float numberFloat2;
    float numberResult;

    // 문자열 변수 선언하기
    //public string name = "윤종혁";
    //public string job;

    // 논리형 변수 선언하기
    bool isMan;
    

    // Start is called before the first frame update
    void Start()
    {
        // 변수의 사용법
        // 변수 이름 = 값;
        //numberSum = numberInt1 / numberInt2;
        //numberRemainder = numberInt1 % numberInt2;

        //numberResult = numberInt1 / numberInt2;

        //numberResult = (float)numberInt1 + (float)numberInt2;
        // 사칙 연산자 : + - * / %

        //number2 = 3.141592f;
        //name = "윤종혁";
        //isMan = false;

        //string result = name + " " + numberInt1;
        //print(result);
        numberSum = Sum(numberInt1, numberInt2);
        print("더하기: " + numberSum);

        numSubtract = Subtract(numberInt1, numberInt2);
        print("빼기: " + numSubtract);

        numMultiply = Multiply(numberInt1, numberInt2);
        print("곱하기: " + numMultiply);

        numDivide = Divide(numberInt1, numberInt2);
        print("나누기: " + numDivide);

        //print(numberSum);
        //print(numberRemainder);
    }


    /// <summary>
    /// 두 정수의 값을 받아 더한 값을 반환하는 함수
    /// </summary>
    /// <param name="num1">첫번째 정수</param>
    /// <param name="num2">두번째 정수</param>
    /// <returns></returns>
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    /// <summary>
    /// 두 정수의 값을 받아 뺀 값을 반환하는 함수
    /// </summary>
    /// <param name="num1">첫번째 정수</param>
    /// <param name="num2">두번째 정수</param>
    /// <returns></returns>
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }


    /// <summary>
    /// 두 정수의 값을 받아 곱한 값을 반환하는 함수
    /// </summary>
    /// <param name="num1">첫번째 정수</param>
    /// <param name="num2">두번째 정수</param>
    /// <returns></returns>
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    /// <summary>
    /// 두 정수의 값을 받아 나눈 값을 반환하는 함수
    /// </summary>
    /// <param name="num1">첫번째 정수</param>
    /// <param name="num2">두번째 정수</param>
    /// <returns></returns>
    int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}
