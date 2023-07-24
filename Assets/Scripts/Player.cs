using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    private float value = 5;
    private string name;
    private int age;
    Player()
    {
        name = "Player";
        age = 25;
    }
    [SerializeField] private Transform _transform;
    [SerializeField] private Transform _transform1;
    [SerializeField] private Transform _transform2;
    [SerializeField] private Transform _transform3;
    void Start()
    {
        //DebugLog();
        //DebugFormatLog();
        //DebugBehavior();
        ////DebugAssert();
        ////DebugLogAssertion();
        //DebugLogException();
        DebugDrawLine();
    }
    private void Update()
    {
        DebugDrawRay();
    }
    void DebugDrawRay()
    {
        Debug.DrawRay(_transform.position,_transform1.position,Color.red);
    }

    void DebugDrawLine()
    {
        Debug.DrawLine(_transform.position, _transform1.position, Color.blue, 20f);
        Debug.DrawLine(_transform2.position,_transform3.position,Color.cyan,20f,true);
    }
    int DebugLogException()
    {
        try
        {
            int result = 0;
            int result1 = 0;
            return result / result1;
        }
        catch (Exception e)
        {
            Debug.LogException(e);
            return 0;
        }
    }
    //private void Update()
    //{
    
    //    //Debug.ClearDeveloperConsole();
    //    //value+=value*Time.deltaTime;
    //    //Debug.Log($"Value: {value}");
    //    //if (value > 20 )
    //    //{
    //    //    //DebugBreak();

    //    //}
    //}
   
    void DebugBreak()
    {
        Debug.Break();
    }

    void DebugLogAssertion()
    {
        if (age > 18)
        {
            Debug.LogAssertion("Kullanýcý 18 yaþýndan büyük");
        }
    }
    void DebugAssert()
    {
        Debug.Assert(age <= 15, "Kullanýcý 18 yaþýndan küçük");
    }

    void DebugBehavior()
    {
        int live = 5;
        Debug.Log("*********");
        if (live == 5)
        {
            Debug.LogWarning($"Oyuncunun caný {live} oldu.");

        }
        Debug.Log("*********");
        int death = -1;
        if (death < 0)
        {
            Debug.LogError($"Oyuncunun caný {death} oldu bunu nasýl baþardýn?");
        }
    }
    void DebugFormatLog()
    {
        Debug.Log("*********");
        Debug.LogFormat(LogType.Exception, LogOption.NoStacktrace, this, "Player Name:{0},Player Age:{1}", name, age);
    }
    // Update is called once per frame
    void DebugLog()
    {
        Debug.Log("*********Debug.Log(message) kullanýldý");
        Debug.Log("Hey Oyun Baþladý Hadi Bir þeyler yapalým:D");
        Debug.Log("*********Debug.Log(message) kullanýldý");
        Debug.Log($"Value: {value}");
        Debug.Log("*********Debug.Log(message,object) kullanýldý");
        Debug.Log($"Transform: {this.transform} ", this);
    }


}


