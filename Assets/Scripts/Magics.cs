using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class Magics
{
    //How to make class objects?
    /// <summary>
    /// Type
    /// Damage
    /// Manacost
    /// Cooldown
    /// spread
    /// range
    /// </summary>
    public delegate float[] Casting(float damage, float manacost, float cooldown, float spread, float range);
    public enum elementName {Fire, Ice, Electric, Water, Earth, Metal, Light, Dark}
    //public float elementDamage = {10f, 0.2f, 0.2f, 5f, 10f, 10f, 0.1f, 0.1f};
    //public elementName GetMagicType(elementName name) => elements[(int)name];
    public static void Fire(float damage, float manacost, float cooldown, float spread, float range){
        Debug.Log("Fire");
    }
    public static void Ice(float damage, float manacost, float cooldown, float spread, float range){
        Debug.Log("Ice");
    }
}