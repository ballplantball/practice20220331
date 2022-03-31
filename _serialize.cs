using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _serialize : MonoBehaviour
{
    [HideInInspector]
    public int count1 = 0;

    [NonSerialized]
    public int count2 = 0;

    [SerializeField]    
    private float score = 0;

    public member[] member;    

    [Serializable]
    public struct student
    {
        public int name;
        public int number;
    }

    public student people;

    private void Start()
    {
        member[0].number = 1;
        member[0].name = "1¸¹";

        member[1] = new member(2, "2¸¹");
    }

    public float timer = 0f;

    public float ModTimer
    {
        get
        {
            return timer;
        }
        set
        {
            timer = value;
            if (timer > 5)
                timer = 0;
        }
    }

    private void FixedUpdate()
    {
        ModTimer += Time.deltaTime;
        print(ModTimer);
    }
}


