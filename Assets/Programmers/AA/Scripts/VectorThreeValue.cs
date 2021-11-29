using UnityEngine;

[CreateAssetMenu(fileName = "Vector3Value", menuName = "ScriptableObjects/Values")]
public class VectorThreeValue : ScriptableObject
{
    [SerializeField] private Vector3 vector3Value;
    
    public Vector3 Vector3Value
    {
        get { return vector3Value; }
        set => vector3Value = value;
    }
}
