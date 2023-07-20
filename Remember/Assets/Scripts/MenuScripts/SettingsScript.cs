using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
public class Settings : MonoBehaviour
{
    public GameObject PanelSet;
    void Start()
    {
        
    }


    public void PanelSettings()
    {
        PanelSet.SetActive(true);
    }

    public void PanelSessingsFalse()
    {
        PanelSet.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PanelSet.SetActive(false);
        }
    }
}
