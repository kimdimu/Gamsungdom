using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class charcontrollerCW : MonoBehaviour
{
    public float speed = 10.0f;     //플레이어 이동속도
    public float rotateSpeed = 10.0f;       //플레이어 회전속도 >>안씀
    public float jumpPower = 3.0f;      //점프력
    public float dashPower = 20f;       //대쉬력

    bool isjumping = false;     //점프?
    bool isdash = false;        //대쉬?

    Rigidbody r_body;
    private Animator anima;
    Vector3 movement;
    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        r_body = GetComponent<Rigidbody>();
        anima = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal")*speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical")*speed * Time.deltaTime;

        transform.Translate(h, 0, v);

        if (Input.GetMouseButtonDown(0))
        {
            transform.localRotation = Quaternion.identity;
        }


        //if (h != 0f || v != 0f)
        //{
        //    anima.SetBool("isRun", true);
        //}
        //else
        //{
        //    anima.SetBool("isRun", false);
        //}

        if (Input.GetButtonDown("Jump"))
            isjumping = true;
        JumpCW();

        if (Input.GetButtonDown("Fire3"))
            isdash = true;
        DashCW();

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        TurnCW();
    }

    void JumpCW()
    {
        if (!isjumping)
            return;


        r_body.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

        isjumping = false;
    }

    void DashCW()
    {
        if (!isdash)
            return;

        r_body.AddForce(transform.forward * dashPower, ForceMode.Impulse);

        isdash = false;
    }

    void TurnCW()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        movement = h * Vector3.forward + v * Vector3.right;

        if (h == 0 && v == 0)
            return;

        //this.transform.rotation = Quaternion.LookRotation(movement);
        //this.transform.Translate(transform.forward * rotateSpeed * Time.deltaTime);
        //Quaternion newRotation = Quaternion.LookRotation(movement);
        //r_body.rotation = Quaternion.Slerp(r_body.rotation, newRotation, rotateSpeed * Time.deltaTime);
    }

}
