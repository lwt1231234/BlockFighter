using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    //初始化参数
    int MaxBlockNum = 10, StartLine_Y = 9;

    //游戏全局参数
    public int BlockSpeed, BulletSpeed, PlayerSpeed, BulletDamage, BlockHealth;

    public GameObject Block;
    //图像参数
    public int BlockWide = 100;

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
        int i,x;
        int[] a = new int[MaxBlockNum];
        for (i = 0; i < MaxBlockNum; i++)
            a[i] = 0;
        for (i=0;i<BlockNum;i++)
        {
            do
            {
                x = Random.Range(0, MaxBlockNum - i);
            } while (a[x] != 0);
            a[x] = 1;
            float y = (x + 0.5f) * BlockWide / 100f - 5f;
            Vector3 Position = new Vector3(y, StartLine_Y+ BlockWide/200f, 0);
            print(Position);
            Instantiate(Block, Position, Quaternion.identity);
        }
        
    }
}
