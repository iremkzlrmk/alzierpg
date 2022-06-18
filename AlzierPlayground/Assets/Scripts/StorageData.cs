using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/StorageData")]
public class StorageData : ScriptableObject
{
    public string name;
    public int age;

    public void reset()
    {
        name = "";
        age = 0;
    }
}
