using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public int moveSpeed = 5;
    public Rigidbody ball;
    public int power = 2000;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(h, v, 0);

        if (Input.GetButtonUp("Fire1"))
        {
            //Debug.Log("Fire1was pressed!");

            Rigidbody instance = Instantiate(ball, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            instance.AddForce(fwd * power);
        }
    }
}
