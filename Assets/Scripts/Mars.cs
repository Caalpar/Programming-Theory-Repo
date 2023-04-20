using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Mars : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Mars is the fourth planet in order of distance from the Sun and the second smallest in the solar system, after Mercury.";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 6779;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
       return 22790000000;
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
