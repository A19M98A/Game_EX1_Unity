using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public int moveSpeed = 5;
    public Rigidbody ball1;
    public Rigidbody ball2;
    public Rigidbody ball3;
    public Rigidbody ball4;
    public int power1 = 1000;
    public int power2 = 1500;
    public int power3 = 2000;
    public int power4 = 2500;

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

            Rigidbody instance = Instantiate(ball1, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            instance.AddForce(fwd * power1);
        }
        if (Input.GetButtonUp("Fire2"))
        {
            //Debug.Log("Fire1was pressed!");

            Rigidbody instance = Instantiate(ball2, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            instance.AddForce(fwd * power2);
        }
        if (Input.GetButtonUp("Fire3"))
        {
            //Debug.Log("Fire1was pressed!");
            int r = Random.Range(3, 5);
            Rigidbody randBall = ball3;
            if (r == 4)
                randBall = ball4;
            Rigidbody instance = Instantiate(randBall, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            instance.AddForce(fwd * power3);
        }
    }
}
