using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Join : MonoBehaviour
{
    [SerializeField]
    private string name;

    private void Start()
    {
        Controller._instance.OnClick += PayEvent;
        Controller._instance.cal += CalEvent;
    }

    void PayEvent(int count)
    {
        print(name + count);
    }

    int CalEvent(int a,int b)
    {
        return a*b;
    }

    private void OnDisable()
    {
        Controller._instance.OnClick -= PayEvent;
        print("bye");
    }
}
