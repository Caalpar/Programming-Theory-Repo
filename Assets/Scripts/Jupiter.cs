using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jupiter : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Jupiter is the largest planet in the solar system and the fifth in order of distance from the Sun. It is a gas giant that is part of the so-called outer planets. It gets its name from the Roman god Jupiter.";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 139820;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 778500000000;
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
