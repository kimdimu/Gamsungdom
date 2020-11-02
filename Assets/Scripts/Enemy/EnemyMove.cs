using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float MoveSpeed;
    Vector3 lookDirection;
    public float RotateSpeed;
    public float TurnTime;
    float TurnT = 0;

    bool pattern = false;

    int fishState;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("a");
        if (other.transform.tag == "mount")
        {
            pattern = true;
        }
    }

    void Update()
    {
        //float xx = fishState;
        float zz = fishState;
        float yy = fishState;
        //lookDirection = zz * Vector3.forward ;

        lookDirection = zz * Vector3.forward;
        lookDirection = yy * Vector3.left;




        if (TurnT < TurnTime)
        {
            TurnT += Time.deltaTime;
        }

        if (TurnT >= TurnTime)
        {
            pattern = true;
        }

        if (pattern == true)
        {
            Debug.Log("D");
            pattern = false;
            TurnT = 0;

            fishState = Random.Range(-1, 4);
        }

        if (fishState == -1)
        {
            transform.position += Vector3.back * MoveSpeed * Time.deltaTime;
            this.transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, -270));

        }
        if (fishState == 0)
        {
            transform.position += Vector3.zero * MoveSpeed * Time.deltaTime;
            this.transform.rotation = Quaternion.LookRotation(lookDirection);
        }
        if (fishState == 1)
        {
            transform.position += Vector3.forward * MoveSpeed * Time.deltaTime;
            this.transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
        }
        if (fishState == 2)
        {
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
            this.transform.rotation = Quaternion.LookRotation(new Vector3(45, 0, 0));
        }
        if (fishState == 3)
        {
            transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
            this.transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }

    //void OnTriggerEnter(Collider col)
    //{
    //    if (col.tag == "Mountain")
    //    {
    //        Debug.Log("Collision");

    //    }
    //}
}