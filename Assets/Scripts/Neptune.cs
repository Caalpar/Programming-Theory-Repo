using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Neptune : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Neptune is the eighth planet in distance from the Sun and the farthest in the solar system. It is part of the so-called outer planets, and within these, it is one of the ice giants, and it is the first to be discovered thanks to mathematical predictions";
    }
    // POLYMORPHISM
    public override float Diameter()
    {
        return 49244;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 4495000000;
               
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
