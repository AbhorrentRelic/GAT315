using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "String", menuName = "data/String")]
public class StringData : ScriptableObject
{
    public string value;

    public static implicit operator string(StringData data) { return data.value; }
}
