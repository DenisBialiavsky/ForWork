using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Exit : MonoBehaviour
{
    public Button ButtonExit;
    void Start()
    {
        ButtonExit = GetComponent<Button>();
        ButtonExit.onClick.AddListener(ApplExit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ApplExit()
    {
        Application.Quit(); 
    }
}
