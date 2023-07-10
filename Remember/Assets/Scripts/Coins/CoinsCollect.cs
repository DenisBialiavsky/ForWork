using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCollect : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public static int coin;
    
    void Update()
    {
        coinText.text = coin + "$";
    }
}
