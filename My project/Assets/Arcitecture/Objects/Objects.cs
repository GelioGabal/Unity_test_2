using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ObjectData", menuName = "Object Data", order = 51)]

public class Objects : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] Sprite icon;
}
