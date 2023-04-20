using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Earth : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "The Earth is a planet of the solar system that revolves around its star – the Sun – in the third innermost orbit. It is the densest and fifth largest of the eight planets in the solar system.It is also the largest of the four terrestrial or rocky";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 12742;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 14960000000;
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
