using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTest : MonoBehaviour
{

    Player player;
    Monster monster;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
        monster = new Monster();


        player.Hp = 10;
        Debug.Log(player.Hp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            player.Hp = monster.Damage(player.Hp, 5);
            Debug.Log(player.Hp);
        }
    }
}

class Monster
{

    
    public int Damage(int playerHp,int damageIndex)
    {
        return playerHp - damageIndex;
    }
}

class Player
{
    public int Hp;
}