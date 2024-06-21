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

        print("ages 배열에서 50이 넘는 인덱스의 총 개수 : " + count.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
