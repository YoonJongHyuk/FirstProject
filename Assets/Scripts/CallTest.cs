using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTest : MonoBehaviour
{
    string testString = "�̰� ���������Դϴ�.";


    private int hp;

    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Test()
    {
        string testString = "�̰� ���������Դϴ�.";
        Debug.Log(this.testString);
        Debug.Log(testString);
    }
}
