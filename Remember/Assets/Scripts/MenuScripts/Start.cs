using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Start : MonoBehaviour
{
    public void StartGame(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }

}
