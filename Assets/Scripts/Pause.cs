using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    [SerializeField]
    GameObject canvas;

    [SerializeField]
    GameObject player;

    public bool paused = false;

    public void Quit() => Application.Quit();
    public void Menu() => SceneManager.LoadScene("Menu");

    public void PauseGame() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
        canvas.SetActive(true);
        paused = true;
        player.GetComponent<PlayerController>().paused = paused;


    }
    public void Unpause() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        canvas.SetActive(false);
        paused = false;
        player.GetComponent<PlayerController>().paused = paused;

    }

    private void Start() => Unpause();


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (paused)
                Unpause();
            else
                PauseGame();
        }
    }

}
