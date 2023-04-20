using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Saturn : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Saturn is the sixth planet in the solar system counting from the Sun, the second in size and mass after Jupiter, and the only one with a ring system visible from Earth.Its name comes from the Roman god Saturn. It is part of the so-called outer or gaseous planets.";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 116460;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 14654000000000;
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
