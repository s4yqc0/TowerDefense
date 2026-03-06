using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//Žc‹@‚ÌŠÇ—
public class LifeManager : MonoBehaviour
{
    public GameObject[] hp = new GameObject[3];
    public int life=3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //====“G‚ÉN“ü‚³‚ê‚½‚çHP‚ÌUI‚ð1‚Â‚¸‚ÂŒ¸‚ç‚·ˆ—====//
        if (/*“G‚ªŠÄŽ‹Žº‚ÉN“ü‚µ‚Ä‚«‚½‚ç&&*/Input.GetMouseButtonDown(0)&& life > 0)
        {
            hp[life - 1].SetActive(false);
            life--;
        }
    }
}
