using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KontrolLoader : MonoBehaviour
{
    public Button kontrolButton;

    // Start is called before the first frame update
    void Start()
    {
        kontrolButton.GetComponent<Button>().onClick.AddListener(StartKontrolOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartKontrolOnClick() {
        SceneManager.LoadScene("default", LoadSceneMode.Single);
    }
}
