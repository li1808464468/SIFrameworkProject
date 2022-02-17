/****************************************************
文件：TestLitJson.cs
作者：haitao.li
日期：2022/01/27 11:12:14
功能：Nothing
*****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using SIFramework.Data;
using SIFramework.Tool;
using UnityEngine;
using UnityEngine.UI;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime Birthday { get; set; }
}

public class TestLitJson : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "{\"type\":\"weighted_random\",\"para\":{\"csvname\":\"weight_config_csv_weight\"}}";
        JsonData data = JsonMapper.ToObject(str);
        
        GetComponent<Text>().text =  LitJsonTool.GetStringValue(data, "type"); 
        
        string json = @"
                    {
                    ""Name""     : ""Thomas More"",
                    ""Age""      : 57,
                    ""Birthday"" : ""02/07/1478 00:00:00""
                    }";

        Person person = JsonMapper.ToObject<Person>(json);


        GetComponent<Text>().text = JsonMapper.ToJson(person);
        
        LOGTools.Log(person.Name);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
