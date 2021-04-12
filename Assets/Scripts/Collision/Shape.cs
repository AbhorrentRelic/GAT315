using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public enum eType
    {
        circle,
        box
    }

    public abstract eType type { get; }
    public abstract float mass { get; }
    public abstract float size { get; set; }

    public float density = 1.0f;
}
