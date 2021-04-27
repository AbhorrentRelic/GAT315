using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
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
    public Color color { set => spriteRenderer.material.color = value; }

    public float density = 1.0f;

    SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

}
