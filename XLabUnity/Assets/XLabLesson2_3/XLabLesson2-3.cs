using System.Collections.Generic;
using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        short s = 0;
        int i = 0;
        long l = 0;
        float f = 0;
        double d = 0;
        object o = d;
        double d2 = (double)o;

        i = (int)l;
        l = i;
        ushort a = 15050; //Вставить звуки бед 
        byte b = (byte)a; //с конвертацией

        TestFunc(ref i);

        var c = 0f;

        if (o != null)
        {
            int i2 = (int)o;
        }
        int[] array = new int[10000];

        List<int> list = new List<int>(80);

        void TestFunc(ref int i)
        {
            i = 10;
            Debug.Log(i);
        }
    }
}

