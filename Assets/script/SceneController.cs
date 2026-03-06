using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public LifeManager lifeManager;
    public WaveManager waveManager;
    // Start is called before the first frame update
    void Start()
    {
        lifeManager=FindObjectOfType<LifeManager>();
        waveManager=FindObjectOfType<WaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //==== ゲームオーバーシーンに切り替え ====//

        if (lifeManager.life <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        //==== ゲームクリアシーンに切り替え ====//
        if (/*waveManager.nowWave == waveManager.maxWave*/Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }
}
