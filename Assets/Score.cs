using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int PinCount;
    public static int level=1;

    public Text text;
    public Text levelui;

    void Start()
    {
        PinCount=0;
         levelui.text="Level "+level.ToString();
    }
    void Update()
    {
        if(PinCount>=10){
            level=level+1;
            PinCount=0;
            levelui.text="Level "+level.ToString();
        }
        text.text=PinCount.ToString();
    }
}
