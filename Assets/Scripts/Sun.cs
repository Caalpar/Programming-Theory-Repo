using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sun : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "The Sun is a G - type star of the main sequence and luminosity class V that is located in the center of the solar system and constitutes the largest source of electromagnetic radiation of this planetary system.";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 13927000000;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 0;
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
