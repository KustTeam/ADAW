using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrow : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.LookAt (target);
        transform.localRotation = Quaternion.Euler (0f, -transform.localRotation.eulerAngles.y, 0f);
    }
}
