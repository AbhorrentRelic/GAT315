using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public enum eType
    {
        Static,
        Kinematic,
        Dynamic
    }

    public enum ForceMode
    {
        Force,
        Acceleration,
        Velocity
    }

    public Shape shape;

    public Vector2 force { get; set; } = Vector2.zero;
    public Vector2 velocity { get; set; } = Vector2.zero;
    public Vector2 acceleration { get; set; } = Vector2.zero;
    public Vector2 position { get { return transform.position; } set { transform.position = value; } }

    public float damping { get; set; } = 0;
    public float mass { get => shape.mass; }

    public eType type { get; set; }


    public void AddForce(Vector2 force, ForceMode forceMode = ForceMode.Force)
    {
        switch (forceMode)
        {
            case ForceMode.Force:
                this.force += force;
                break;
            case ForceMode.Acceleration:
                this.acceleration = force;
                break;
            case ForceMode.Velocity:
                this.velocity = force;
                break;
            default:
                break;
        }
    }

    public void Step(float dt)
    {
        acceleration = World.Instance.Gravity + (force / mass);
    }
}
