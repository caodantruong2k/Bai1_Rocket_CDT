using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Cache
{
    private static Dictionary<Character, Character> transforms = new Dictionary<Character, Character>();

    private static Dictionary<Collider, Sphere> sphere = new Dictionary<Collider, Sphere>();

    public static Sphere GetSphere(Collider collider)
    {
        if (!sphere.ContainsKey(collider))
        {
            sphere.Add(collider, collider.GetComponent<Sphere>());
        }

        return sphere[collider];
    }
    public static Character GetTransform(Character transform)
    {
        if (!transforms.ContainsKey(transform))

        {
            transforms.Add(transform, transform.GetComponent<Character>());
        }
        return transform;
    }

}
