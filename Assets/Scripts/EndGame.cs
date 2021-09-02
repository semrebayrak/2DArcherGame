using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{

    public Text scoretext;
    public GameObject EndGameMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        EndGameMenuUI.SetActive(false);
    }
    public void Update()
    {
       
    }

    public void ToggleEndMenu(float score)
    {
        EndGameMenuUI.SetActive(true);
        scoretext.text = ((int)score).ToString();
    }
    // Update is called once per frame
    
    public void Quit()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();

    }
}
