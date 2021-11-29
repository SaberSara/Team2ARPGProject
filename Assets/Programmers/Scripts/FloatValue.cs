using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FloatValue", menuName = "Value/Float")]
public class FloatValue : ScriptableObject
{
    [SerializeField] private float floatValue;

    public float Float
    {
        get => floatValue;
        set => floatValue = value;
    }
}
