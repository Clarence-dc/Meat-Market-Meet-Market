using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cooldownTimer : MonoBehaviour

{
    public Image cooldownTime;
    public Text timerobj;
    public float totaltime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        totaltime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        totaltime = totaltime - Time.deltaTime;
        if (totaltime > 0)
        {
            timerobj.text = totaltime.ToString("0");
            //cooldownTime.fillAmount -= 1.0f / 10 * Time.deltaTime;
            cooldownTime.rectTransform.sizeDelta = new Vector2(10 * totaltime, 15); 
        }
        else
        {
            timerobj.text = "0";
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(totaltime<=0)
            totaltime = 10.0f;
        }
        //maxvalue/totaltime timer*framerate
    }
}
