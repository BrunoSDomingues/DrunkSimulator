using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour
{
    [SerializeField] GameObject main;
    public GameObject canvasIntro, canvasControls;

    public void ShowControls()
    {
        canvasIntro.SetActive(false);
        canvasControls.SetActive(true);
    }

    public void Play()
    {
        Debug.Log("Changed to game");
        SceneManager.LoadScene("Game");
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
