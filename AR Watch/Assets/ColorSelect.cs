using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ColorSelect : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "black button")
        {
            // change the color to black

            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out mycolor);
            band1.color = mycolor;
        }
        else if (buttonName == "blue button")
        {
            // change the color to blue
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#103B90", out mycolor);
            band1.color = mycolor;
        }
    }

    public void w2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "black button")
        {
            // change the color to black
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out mycolor);
            band2.color = mycolor;
        }
        else if (buttonName == "red button")
        {
            // change the color to red
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out mycolor);
            band2.color = mycolor;
        }
    }

    public void w3ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if (buttonName == "black button")
        {
            // change the color to black
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#464646", out mycolor);
            band3.color = mycolor;
        }
        else if (buttonName == "silver button")
        {
            // change the color to silver
            Color mycolor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1", out mycolor);
            band3.color = mycolor;
        }
    }
}
