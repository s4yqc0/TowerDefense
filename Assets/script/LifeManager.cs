using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//残機の管理
public class LifeManager : MonoBehaviour
{
    public GameObject[] hp = new GameObject[3];
    private int life=3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //====敵に侵入されたらHPのUIを1つずつ減らす処理====//
        if (/*敵が監視室に侵入してきたら&&*/Input.GetMouseButtonDown(0)&& life > 0)
        {
            hp[life - 1].SetActive(false);
            life--;
        }

        //====残機が0になったらゲームオーバーシーンに切り替え====//
        if (life == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
