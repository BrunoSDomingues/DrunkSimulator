using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    [SerializeField] GameObject main;

    public void Play() {
        Debug.Log("Scenou");
        SceneManager.LoadScene("Game");
    }
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Startou");

    }

    // Update is called once per frame
    void Update() {

    }
}
