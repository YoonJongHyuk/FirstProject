using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    int[] ages = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        ages[0] = 20;

        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = i * 10;
        }

        for (int i = 0; i < 10; i++)
        {
            print("index: " + i.ToString() + ", value: " + ages[i].ToString());
        }

        int count = 0;

        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] > 50)
            {
                count++;
            }
        }

        print("ages �迭���� 50�� �Ѵ� �ε����� �� ���� : " + count.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
