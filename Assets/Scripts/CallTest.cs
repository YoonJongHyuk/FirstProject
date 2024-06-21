using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTest : MonoBehaviour
{
    string testString = "이건 전역변수입니다.";


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
        string testString = "이건 지역변수입니다.";
        Debug.Log(this.testString);
        Debug.Log(testString);
    }
}
