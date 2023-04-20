using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Venus : Planet
{
    // POLYMORPHISM
    public override string Description()
    {
        return "Venus is the second planet in the solar system in order of proximity to the Sun and the third smallest after Mercury and Mars. Like Mercury, it lacks natural satellites. It is named after Venus, the Roman goddess of love.";
    }

    // POLYMORPHISM
    public override float Diameter()
    {
        return 60518 * 2;
    }
    // POLYMORPHISM
    public override float DistanToSun()
    {
        return 1082000000;
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
