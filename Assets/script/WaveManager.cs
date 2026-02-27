using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ウェーブの管理
public class WaveManager : MonoBehaviour
{
    private int nowWave = 1;
    private int maxWave = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        //====enemyが0だったら次のウェーブに行く====//
        if (nowWave >= maxWave && enemies.Length == 0)
        {
            NextWave();
        }

        if(nowWave==maxWave)
        {
            //ゲームクリア処理
        }
    }

    void NextWave()
    {
        nowWave++;
    }
}
