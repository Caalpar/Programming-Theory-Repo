using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadSence : MonoBehaviour
{

    [SerializeField]
    private TMP_InputField userText;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
    // ENCAPSULATION SINGLETON PATRON
    public LoadSence Instance { get; private set; }

    // ENCAPSULATION
    public string PlayerName { get; private set; }


    // Update is called once per frame
    void Update()
    {
        if (userText.text != "" && Input.GetKeyDown(KeyCode.Return))
        {
            Instance.PlayerName = userText.text;
            SceneManager.LoadScene(1);
        }
    }
}
