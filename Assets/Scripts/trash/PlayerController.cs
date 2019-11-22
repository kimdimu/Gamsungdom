using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalSensitivity = 10;

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddTorque(0, Input.GetAxis("Mouse X") * horizontalSensitivity, 0);
    }
}
