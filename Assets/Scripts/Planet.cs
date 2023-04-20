using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Planet : MonoBehaviour
{
    // ABSTRACTION
    protected string setType = "celestial body";
    // ABSTRACTION
    public abstract string Description();
    public abstract float DistanToSun();
    public abstract float Diameter();

}
