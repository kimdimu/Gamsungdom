using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public float jumpPower = 3f;
    public float dashPower = 20f;
    public float rotateSpeed = 5f;
    public float dashcooltime = 0f;
    public float dashcoolspeed = 10f;
    public Camera cam;

    //    private float timeStamp;

    Rigidbody r_body;
    Vector3 movement;

    bool isjumping = false;
    bool isdash = false;

    private Animator anima;
    ///
    void Awake()
    {
        r_body = GetComponent<Rigidbody>();
        anima = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            isjumping = true;

        if (Input.GetButtonDown("Fire3"))
            isdash = true;
        //if (dashcooltime > 0)
        //{
        //    dashcooltime -= Time.deltaTime * dashcoolspeed;
        //    if (dashcooltime < 0)
        //    {
        //        dashcooltime = 0;
        //            isdash = true;

        //    }
        //}

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Run(h, v);
        Jump();
        Dash();
        Turn();
    }

    void MoveLookAt()
    {
        Vector3 dir = cam.transform.localRotation * Vector3.forward;
        transform.localRotation = cam.transform.localRotation;
        transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
        gameObject.transform.Translate(dir * 0.1f * Time.deltaTime);
    }

    void Run(float h, float v)
    {
        if (h != 0f || v != 0f)
        {
            movement.Set(h, 0, v);
            movement = movement.normalized * speed * Time.smoothDeltaTime;

            r_body.MovePosition(r_body.position + movement);

            anima.SetBool("isRun", true);
        }

        else
        {
            anima.SetBool("isRun", false);
        }

    }

    void Jump()
    {
        if (!isjumping)
            return;


        r_body.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

        isjumping = false;
    }

    void Dash()
    {
        if (!isdash)
            return;

        r_body.AddForce(transform.forward * 2 * dashPower, ForceMode.Impulse);

        isdash = false;
    }

    void Turn()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (h == 0 && v == 0)
            return;

        Quaternion newRotation = Quaternion.LookRotation(movement);
        r_body.rotation = Quaternion.Slerp(r_body.rotation, newRotation, rotateSpeed * Time.deltaTime);



    }
}
    /*   void moveObject()
       {
             float keyHorizontal = Input.GetAxis("Horizontal");
             float keyVertical = Input.GetAxis("Vertical");

             transform.Translate(Vector3.right * speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
             transform.Translate(Vector3.forward * speed * Time.smoothDeltaTime * keyVertical, Space.World);

       }*/
//    void OnCollisionEnter(Collider other)
//      {
//          if (other.transform.tag == "destroy")
//          {
//               Destroy(other.transform);
//          }
//      }
//}
