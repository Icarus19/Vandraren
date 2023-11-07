/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiring : MonoBehaviour
{
    private Magics leftMagic, rightMagic;
    //[SerializeField] private PlayerLookRotation otherObj;
    [SerializeField] private float fireRate, spawnPoint;
    [SerializeField] private GameObject fire, ice;
    //private int fireCooldown = 1, altFireCooldown = 200, doubleFireCooldown;

    private Vector3 magicSpawn;
    private IEnumerator cooldown;
    //Creates new objects of class Magics
    void Start()
    {
        leftMagic = new Magics();
        rightMagic = new Magics();
    }

    private void Update()
    {
        //doubleFireCooldown = fireCooldown + altFireCooldown;
        //calls the shooting functions depeding on left, right or double clicking the mouse
        if(((Input.GetAxis("Fire1") == 1) && (Input.GetAxis("Fire2") == 1)) && fireRate <= 0)
        {
        } else if(Input.GetAxis("Fire1") == 1 && fireRate <= 0) {
            Fire();
            cooldown = Cooldown(leftMagic.mainHandCooldown);
            StartCoroutine(cooldown);
        } else if(Input.GetAxis("Fire2") == 1 && fireRate <= 0)
        {
            AltFire();
            cooldown = Cooldown(rightMagic.offhandCooldown);
            StartCoroutine(cooldown);
        }
        //magicSpawn = otherObj.GetComponent<PlayerLookRotation>().Targeting();
    }

    //A wait timer that waits for as long as you input
    IEnumerator Cooldown(float tmp)
    {
        fireRate = tmp;

        yield return new WaitForSeconds(tmp);
    
        fireRate = 0;
    }
    //Shoots fire currently, will change in future
    public void Fire()
    {
        Debug.Log($"Fire {leftMagic.mainHandElement} in the hole");
        Instantiate(fire, transform.position + (transform.forward * spawnPoint), transform.rotation);
    }
    //Shoots ice currently, will also change in the future
    public void AltFire()
    {
        Debug.Log($"Alternativ fire {rightMagic.offhandElement} in the hole");
        Instantiate(ice, transform.position + (transform.forward * spawnPoint), transform.rotation);
    }
    public void DoubleFire()
    {
        //Debug.Log($"Firing {leftClick.elements[0]} and {rightClick.elements[1]}");
    }

    /*Joining all firing functions into one by using arguments
    Using an additional Coroutine in the firing function to allow for channeling spells
    Fixing the Magic class to allow for presets of magics and changes to them
}*/
