using System;
using UnityEngine;
using UnityEngine.UI;

public class DataButton : NormalButton
{
    [SerializeField] private InputField[] fields;
    [SerializeField] private StorageData data;
    
    public void getData()
    {
        for (int i=0; i<fields.Length; i++)
        {
            InputField field = fields[i];
            switch (field.name)
            {
                case "age":
                {
                    data.age = Int32.Parse(field.text);
                    break;
                }
                case "name":
                {
                    if (field.text == "")
                    {
                        throw new Exception("");
                    }
                    data.name = field.text;
                    break;
                }
            }
        }
    }
    
    public void onClick()
    {
        try
        {
            getData();
            changeScene(1);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }
}