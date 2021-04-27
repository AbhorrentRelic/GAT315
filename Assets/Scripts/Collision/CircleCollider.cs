using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

struct CircleCollider
{
    public float radius;
    public Vector2 center;

    public CircleCollider(Vector2 center, float radius)
    {
        this.radius = radius;
        this.center = center;
    }

    public bool Contatins(Vector2 point)
    {
        Vector3 direction = center - point;
        float sqrDistance = direction.sqrMagnitude;
        float sqrRadius = (radius * radius);

        return (sqrDistance <= sqrRadius);
    }

    public bool Contains(CircleCollider circle)
    {
        Vector2 direction = center - circle.center;
        float sqrDistance = direction.sqrMagnitude;
        float sqrRadius = (radius + circle.radius) * (radius + circle.radius);

        return (sqrDistance <= sqrRadius);
    }
}
