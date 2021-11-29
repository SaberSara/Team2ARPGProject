using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IntValue", menuName = "Value/Int")]
public class IntegerValue : ScriptableObject
{
    [SerializeField] private int intValue;
    public int Int
    {
        get => intValue;
        set => intValue = value;
    }
}
