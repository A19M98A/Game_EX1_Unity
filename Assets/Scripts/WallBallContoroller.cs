using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBallContoroller : MonoBehaviour
{
    public float Y = 1;
    public float X = 1;
    public float Z = 1;
    public float maxY = 3;
    public int N = 1;
    public float sped = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Y = transform.position.y;
        X = transform.position.x;
        Z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(X, Y, Z);
        Y += N * sped;
        if (Y > maxY)
            N = -N;
        if (Y < 1)
            N = -N;
    }
}
