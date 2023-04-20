using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Planet : MonoBehaviour
{
    public abstract string Description();
    public abstract float DistanToSun();
    public abstract float Diameter();
}
