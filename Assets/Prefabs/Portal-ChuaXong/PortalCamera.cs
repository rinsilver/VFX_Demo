using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform Portal;
    public Transform otherPortal;

    void Update()
    {
       Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        transform.position = Portal.position + playerOffsetFromPortal;
    }
}
