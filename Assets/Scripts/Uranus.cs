using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Uranus : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Uranus is the seventh planet in the solar system, the third largest, and the fourth most massive. It is named in honor of the Greek goddess of the sky, Uranus, the father of Cronus and the grandfather of Zeus.";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 50724;
    }
    // POLYMORPHIS
    public override float DistanToSun()
    {
        return 2871000000000; 
    }

    void OnMouseDown()
    {
        GameObject.Find("PanelText").transform.GetChild(0).gameObject.SetActive(true);
        TextMeshProUGUI type = GameObject.Find("Type").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI description = GameObject.Find("Description").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI distanceToSun = GameObject.Find("DistanceToSun").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI diameter = GameObject.Find("Diameter").GetComponent<TextMeshProUGUI>();

        type.text = setType;
        description.text = Description();
        distanceToSun.text = "Distan to sun:" + DistanToSun().ToString();
        diameter.text = "Diameter:" + Diameter().ToString();

    }
}
