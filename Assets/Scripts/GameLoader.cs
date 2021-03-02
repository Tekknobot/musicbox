using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    public Button matchButton;

    // Start is called before the first frame update
    void Start()
    {
        matchButton.GetComponent<Button>().onClick.AddListener(StartMatchOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartMatchOnClick() {
        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }
}
