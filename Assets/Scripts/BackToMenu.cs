using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{

    public void Back_ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ClosePanel()
    {
        GameObject.Find("PanelText").transform.GetChild(0).gameObject.SetActive(false);
    }
}
