using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magics : MonoBehaviour
{
    private string fire = "fire", ice = "ice", electric = "electric", water = "water", earth = "earth", metal = "metal", element01 = "Basic element01", element02 = "Basic element02";

    public void StoreElement01(int i)
    {
        switch(i)
        {
            case 1:
                element01 = fire;
                break;
            
            case 2:
                element01 = ice;
                break;
            case 3:
                element01 = electric;
                break;
            case 4:
                element01 = water;
                break;
            case 5:
                element01 = earth;
                break;
            case 6:
                element01 = metal;
                break;
            default:
                break;
        }
    }
    public void StoreElement02(int i)
    {
        switch(i)
        {
        case 1:
            element02 = fire;
            break;
        case 2:
            element02 = ice;
            break;
        case 3:
            element02 = electric;
            break;
        case 4:
            element02 = water;
            break;
        case 5:
            element02 = earth;
            break;
        case 6:
            element02 = metal;
            break;
        }
    }
    public void Fire()
    {
        Debug.Log($"Fire {element01} in the hole");
    }

    public void AltFire()
    {
        Debug.Log($"Alternativ fire {element02} in the hole");
    }
    public void DoubleFire()
    {
        Debug.Log($"Firing {element01} and {element02}");
    }
}
