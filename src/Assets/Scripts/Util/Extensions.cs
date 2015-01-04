using System;
using UnityEngine;

namespace Assets.Scripts.Util
{
    public static class Extensions
    {
        public static string ToFormat(this string s, params string[] p)
        {
            return string.Format(s, p);
        }

        public static Vector3 ToVector3(this Vector2 v)
        {
            return new Vector3(v.x, v.y, 0);
        }

        public static float MoveTowards(this float f, float d, float s)
        {
            if (Math.Abs(f - d) < s) return d;
            if (f < d) return f + s;
            else return f - s;
        }
    }
}
