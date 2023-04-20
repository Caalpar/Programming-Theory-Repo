using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pluton : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Pluto, designated Pluto, is a dwarf planet in the solar system located below the orbit of Neptune, discovered by Clyde Tombaugh on February 18, 1930. Its name is due to the Roman mythological god Pluto";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 2376.6f;

    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 5890199040;
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
