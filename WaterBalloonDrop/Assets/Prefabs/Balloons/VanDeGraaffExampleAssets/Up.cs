using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    private void FixedUpdate()
    {
        Vector3 up = transform.TransformDirection(new Vector3(0.0f, 3.2f, 0.0f));
        GetComponent<Rigidbody>().AddTorque(new Vector3(-3.0f * up.z, 0.0f, 3.0f * up.x));
    }
}
