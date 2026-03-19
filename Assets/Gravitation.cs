using NUnit.Framework;
using UnityEngine;

public class Gravitation : MonoBehaviour
{
    public static List<Gravitation> otherObject;
    private Rigidbody rb;
    const float G = 0.006673f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (otherObject == null)
        {
            otherObjects = new List<Gravitation>();
        }
    }
}
