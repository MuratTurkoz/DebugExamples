using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int value = 5;
    private string name;
    private int age;
    Player()
    {
        name = "Player";
        age = 25;
    }
    void Start()
    {
        //DebugLog();
        //DebugFormatLog();
        DebugBehavior();
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


