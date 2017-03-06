using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    //初始化参数
    int MaxBlockNum = 20, StartLine_Y = 9;

    //游戏全局参数
    public int BlockSpeed, BulletSpeed, PlayerSpeed, BulletDamage, BlockHealth;

    public GameObject Block;
    //图像参数
    int BlockWide = 50;

    //游戏局部变量
    int BlockNum;

    // Use this for initialization
    void Start () {
        //速度
        BlockSpeed = 1;
        BulletSpeed = 3;
        PlayerSpeed = 5;
        //伤害和血量
        BulletDamage = 1;
        BlockHealth = 3;
        BlockNum = 1;

        CreatNewLine();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreatNewLine()
    {
        int i;
        
        for (i=0;i<BlockNum;i++)
        {
			float x = (Random.Range(0, MaxBlockNum - i) - 10f)/2f + BlockWide/200f;
            Vector3 Position = new Vector3(x, StartLine_Y+0.25f, 0);
            Instantiate(Block, Position, Quaternion.identity);
        }
        
    }
}
