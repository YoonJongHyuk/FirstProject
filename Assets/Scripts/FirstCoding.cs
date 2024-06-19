using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ù �ڵ� ������ �ڵ��̴�.
/// </summary>
public class FirstCoding : MonoBehaviour
{
    // ������ ���� �����ϱ�
    public int numberInt1 = 5;
    public int numberInt2 = 3;


    int numberSum;
    int numSubtract;
    int numMultiply;
    int numDivide;



    int numberRemainder;

    // �Ǽ��� ���� �����ϱ�
    //public float numberFloat1;
    //public float numberFloat2;
    float numberResult;

    // ���ڿ� ���� �����ϱ�
    //public string name = "������";
    //public string job;

    // ���� ���� �����ϱ�
    bool isMan;
    

    // Start is called before the first frame update
    void Start()
    {
        // ������ ����
        // ���� �̸� = ��;
        //numberSum = numberInt1 / numberInt2;
        //numberRemainder = numberInt1 % numberInt2;

        //numberResult = numberInt1 / numberInt2;

        //numberResult = (float)numberInt1 + (float)numberInt2;
        // ��Ģ ������ : + - * / %

        //number2 = 3.141592f;
        //name = "������";
        //isMan = false;

        //string result = name + " " + numberInt1;
        //print(result);
        numberSum = Sum(numberInt1, numberInt2);
        print("���ϱ�: " + numberSum);

        numSubtract = Subtract(numberInt1, numberInt2);
        print("����: " + numSubtract);

        numMultiply = Multiply(numberInt1, numberInt2);
        print("���ϱ�: " + numMultiply);

        numDivide = Divide(numberInt1, numberInt2);
        print("������: " + numDivide);

        //print(numberSum);
        //print(numberRemainder);
    }


    /// <summary>
    /// �� ������ ���� �޾� ���� ���� ��ȯ�ϴ� �Լ�
    /// </summary>
    /// <param name="num1">ù��° ����</param>
    /// <param name="num2">�ι�° ����</param>
    /// <returns></returns>
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    /// <summary>
    /// �� ������ ���� �޾� �� ���� ��ȯ�ϴ� �Լ�
    /// </summary>
    /// <param name="num1">ù��° ����</param>
    /// <param name="num2">�ι�° ����</param>
    /// <returns></returns>
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }


    /// <summary>
    /// �� ������ ���� �޾� ���� ���� ��ȯ�ϴ� �Լ�
    /// </summary>
    /// <param name="num1">ù��° ����</param>
    /// <param name="num2">�ι�° ����</param>
    /// <returns></returns>
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    /// <summary>
    /// �� ������ ���� �޾� ���� ���� ��ȯ�ϴ� �Լ�
    /// </summary>
    /// <param name="num1">ù��° ����</param>
    /// <param name="num2">�ι�° ����</param>
    /// <returns></returns>
    int Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}
