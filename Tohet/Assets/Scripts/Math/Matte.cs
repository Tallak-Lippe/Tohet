using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matte
{
    public static Vector3 RotateX(Vector3 v, float angle)
    {
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);

        float ty = v.y;
        float tz = v.z;
        return new Vector3(v.x, (cos * ty) - (sin * tz), (cos * tz) + (sin * ty));
    }
}
