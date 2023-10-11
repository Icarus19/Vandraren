using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFiring : MonoBehaviour
{
    [SerializeField] private float fireRate;
    private int fireCooldown = 10, altFireCooldown = 20, doubleFireCooldown;

    private IEnumerator cooldown;

    private void Update()
    {
        doubleFireCooldown = fireCooldown + altFireCooldown;
        if(((Input.GetAxis("Fire1") == 1) && (Input.GetAxis("Fire2") == 1)) && fireRate <= 0)
        {
            GetComponent<Magics>().DoubleFire();
            cooldown = Cooldown(doubleFireCooldown);
            StartCoroutine(cooldown);
        } else if(Input.GetAxis("Fire1") == 1 && fireRate <= 0) {
            GetComponent<Magics>().Fire();
            cooldown = Cooldown(fireCooldown);
            StartCoroutine(cooldown);
        } else if(Input.GetAxis("Fire2") == 1 && fireRate <= 0)
        {
            GetComponent<Magics>().AltFire();
            cooldown = Cooldown(altFireCooldown);
            StartCoroutine(cooldown);
        }
    }
    IEnumerator Cooldown(int tmp)
    {
        fireRate = tmp;
        for (int i = tmp; i > 0; i--)
        {
            fireRate--;
            yield return new WaitForSeconds(.1f);
        }
    }
}
