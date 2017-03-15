using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    //游戏状态
    public bool NotPaused;


    //初始化参数
    int MaxBlockNum = 10, StartLine_Y = 9;

    //游戏全局参数
    //玩家参数
    public int PlayerSpeed;
    public float ShootInterval;
    //子弹参数
    public int BulletSpeed, BulletDamage;
    //方块参数
    public int BlockSpeed, BlockHealth;

    //游戏局部参数
    //难度
    float BlockInterval;

    public GameObject Block,Player;
    //图像参数
    public int BlockWide = 100;

    //游戏局部变量
    int BlockNum;

    // Use this for initialization
    void Start () {
        //游戏状态
        NotPaused = true;

        //玩家参数
        PlayerSpeed = 5;
        ShootInterval = 1.0f;
        //子弹参数
        BulletSpeed = 3;
        BulletDamage = 1;
        //砖块参数
        BlockSpeed = 5;
        BlockHealth = 1;
        //难度
        BlockNum = 3;
        BlockInterval = 3.0f;

        CreatNewLine();
        Vector3 Position = new Vector3(0, -7.2f, 0);
        Instantiate(Player, Position, Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreatBlock(Vector3 Position)
    {
        Instantiate(Block, Position, Quaternion.identity);
    }

    public void CreatNewLine()
    {
        if (!NotPaused)
            return;
        int i,x;
        int[] a = new int[MaxBlockNum];
        for (i = 0; i < MaxBlockNum; i++)
            a[i] = 0;
        if (BlockNum > MaxBlockNum)
            BlockNum = MaxBlockNum;
        for (i=0;i<BlockNum;i++)
        {
            do
            {
                x = Random.Range(0, MaxBlockNum - i);
            } while (a[x] != 0);
            a[x] = 1;
            float y = (x + 0.5f) * BlockWide / 100f - 5f;
            Vector3 Position = new Vector3(y, StartLine_Y+ BlockWide/200f, 0);
            CreatBlock(Position);
        }
        Invoke("CreatNewLine", BlockInterval);
    }
}
