using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Electricity : MonoBehaviour
{
    private Slider slider;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        slider=GetComponent<Slider>();
        button = GetComponent<Button>();
        slider.value = 50.0f;//仮初期値
    }

    // Update is called once per frame
    void Update()
    {
        //時間で徐々に増えていく
        slider.value += 0.005f;
            OnClick();//これまだ途中
        
    }



    public void OnClick()
    {
        Debug.Log("赤色クリック");
    }
}
