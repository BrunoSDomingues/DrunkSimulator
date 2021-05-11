using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    [SerializeField] GameObject main;

    public void Play() {
        Debug.Log("Changed to warning");
        SceneManager.LoadScene("Menu 1");
    }
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }
}
