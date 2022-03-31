using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class member
{
    public int number;
    public string name;
    public member(int id, string myname)
    {
        number = id;
        name = myname;
    }

}