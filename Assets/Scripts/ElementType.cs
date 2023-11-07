using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementType : MonoBehaviour
{
    /// <summary>
    /// Type
    /// Damage
    /// Manacost
    /// Cooldown
    /// spread
    /// range
    /// </summary>
    public enum elementName {fire, ice, electric, water, earth, metal, light, dark}
    public float[] elementDamage = {10f, 0.2f, 0.2f, 5f, 10f, 10f, 0.1f, 0.1f};
}
