using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static Controller _instance ;
    public delegate void onClickEvent(int count);
    public onClickEvent OnClick;

    int Add(int x,int y)
    {
        return x+y;
    }
    public delegate int calcuater(int x, int y);
    public calcuater cal;

    private void Awake()
    {
        _instance = this;
        //cal = this.Add;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnClick(50);
            print(cal(3, 3));
            print("get100");
        }
    }

}
