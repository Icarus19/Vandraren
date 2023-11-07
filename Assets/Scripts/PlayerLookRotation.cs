using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookRotation : MonoBehaviour
{
    private Ray ray;

    private Vector3 raiseTargetFromGround = new Vector3(0f, 1f, 0f);

    [SerializeField] private LayerMask terrain;

    [SerializeField] private Transform mousePos;
    [SerializeField] private Camera gameCamera;

    public Vector3 magicSpawnLocation;
    private void FixedUpdate()
    {
        //Makes a variable storing the color yellow
        var laserTargetColor = Color.yellow;
        //A raycast aimed from the camera to mouseposition
        ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        //these if statements overlap eachother and decide the color of the ray
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
        //
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
            //Adjusts the mouseposition to prevent the player from staring straight at the ground
            var playerTarget = hitInfo.point + raiseTargetFromGround;
            //Draws a line from the player to mouseposition
            Debug.DrawLine(transform.position, playerTarget, Color.green);
        }
        //Rotates the player to aim at the mousecurser
        transform.LookAt(mousePos);
    }

    /*public Vector3 Targeting()
    {
        magicSpawnLocation = (transform.position - mousePos);
        return magicSpawnLocation;
    }*/
}