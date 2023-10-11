using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookRotation : MonoBehaviour
{
    private Ray ray;

    private Vector3 relativePos, raiseTargetFromGround = new Vector3(0f, 1f, 0f);

    [SerializeField] private LayerMask terrain;

    [SerializeField] private Transform mousePos;
    [SerializeField] private Camera gameCamera;
    private void FixedUpdate()
    {
        var laserTargetColor = Color.yellow;
        ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Input.GetAxis("Fire1") == 1)
        {
            laserTargetColor = Color.red;
        }
        if(Input.GetAxis("Fire2") == 1)
        {
            laserTargetColor = Color.blue;
        }
        if((Input.GetAxis("Fire1") == 1) && (Input.GetAxis("Fire2") == 1))
        {
            laserTargetColor = Color.white;
        }
        if (Physics.Raycast(ray, out hitInfo, 100, terrain))
        {
            //Draws a line from camera to mousePos in the color red
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            Debug.DrawLine(transform.position, hitInfo.point, laserTargetColor);
            //This moves whatever gameobject we have assigned as mousePos to the position of our mousePos
            var playerTarget = hitInfo.point + raiseTargetFromGround;
            mousePos.position = playerTarget;
            //This rotates our mousePos object to the orientation of whatever the raycast hits
            mousePos.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        } else {
            //This draws a green line from the camera in the direction of our mousePos as long as we don't hover over anything
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
            var playerTarget = hitInfo.point + raiseTargetFromGround;
            Debug.DrawLine(transform.position, playerTarget, Color.green);
        }
        transform.LookAt(mousePos);
    }
}