using UnityEngine;

public class UI : MonoBehaviour {
    [SerializeField]
    GameObject canvas;

    [SerializeField]
    GameObject player;

    public bool paused = false;

    public void Quit() => Application.Quit();
    public void Menu() { }
    public void Pause() {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        canvas.SetActive(true);
    }
    public void Unpause() {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        canvas.SetActive(false);
    }

    private void Start() => Unpause();


    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (paused)
                Unpause();
            else
                Pause();

            paused = !paused;

            player.GetComponent<PlayerController>().paused = paused;

        }
    }

}
