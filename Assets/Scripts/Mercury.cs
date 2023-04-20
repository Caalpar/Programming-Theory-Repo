using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mercury : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Mercury is the planet in the solar system closest to the Sun and the smallest. It is part of the so-called inner planets and lacks natural satellites like Venus.";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 48794;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 58000000;
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
