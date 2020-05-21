using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startTime;

    private Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(startTime > 0)
        {
            startTime -= Time.deltaTime;
            txt.text = "" + startTime;
        }
        else
        {
            txt.text = "0.000";
        }
       
    }
}
