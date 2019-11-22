using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    public const float Y_ANGLE_MIN = -50.0f;
    public const float Y_ANGLE_MAX = 50.0f;

    public GameObject player;
    public Rigidbody RB;

    public Transform LookAt;
    public Transform camTransform;

    private Camera cam;

    public float rotateSpeed = 5f;
    public float distance = 10.0f;
    public float currentX = 0.0f;
    public float currentY = 0.0f;
    public float sensivityX = 4.0f;
    public float sensivityY = 1.0f;

    //private float

    // Update is called once per frame
    void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    void Update()
    {

        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY*-1, currentX*-1, 0);
        //Quaternion birdrotation = player.transform.rotation;
        //birdrotation = Quaternion.Euler(currentY, currentX,0);
        // 카메라를 돌리ㅕㅁㄴ 캐릭터의 로컬 방향이 변한다 면?

        //Quaternion newRotation = Quaternion.LookRotation(player.transform.rotation);
        //RB.rotation = Quaternion.Slerp(RB.rotation, newRotation, rotateSpeed * Time.deltaTime);

        camTransform.position = LookAt.position + rotation * dir;
        camTransform.LookAt(LookAt.position);
    }


    //if (Input.GetAxis("Mouse Y") < 0)
    //    transform.Rotate(speed * Time.deltaTime, 0, 0);
    //if (Input.GetAxis("Mouse Y") > 0)
    //    transform.Rotate(-speed * Time.deltaTime, 0, 0);
}
