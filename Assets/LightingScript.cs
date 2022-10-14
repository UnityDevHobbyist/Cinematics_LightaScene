using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WithForeachLoop();
        //WithForLoop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WithForeachLoop()
    {
        foreach (Transform child in transform)
        {
            if (child.transform.name == "CeilingLights")
            {
                foreach (Transform child_2 in child.transform)
                {
                    foreach (Transform child_3 in child_2.transform)
                    {
                        if (child_3.transform.name == "P_Lamp_ON")
                        {
                            child_3.gameObject.SetActive(true);
                            Light l = child_3.gameObject.AddComponent(typeof(Light)) as Light;
                        }
                    }
                }
            }
        }

        foreach (Transform child in transform)
        {
            if (child.transform.name == "CeilingLights")
            {
                foreach (Transform child_2 in child.transform)
                {
                    foreach (Transform child_3 in child_2.transform)
                    {
                        if (child_3.transform.name == "P_Lamp_ON")
                        {
                            Light myLight;
                            myLight = child_3.GetComponent<Light>();
                            myLight.intensity = .5f;
                        }
                    }
                }
            }
        }
    }

    void WithForLoop()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; ++i)
            print("For loop: " + transform.GetChild(i));
    }
}
