using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xmousemov : MonoBehaviour
{

    public float distance = 10.0f;
    public float currentX = 0.0f;
    public Transform LookAt;

    public Transform camTransform;

    private Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        currentX += Input.GetAxis("Mouse X");
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(0, currentX * -1, 0);

        camTransform.position = LookAt.position + rotation * dir;
        camTransform.LookAt(LookAt.position);
    }
}
