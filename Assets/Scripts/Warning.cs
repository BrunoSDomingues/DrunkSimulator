using UnityEngine;
using UnityEngine.SceneManagement;

public class Warning : MonoBehaviour {
    [SerializeField] GameObject main;

    public void Play() {
        Debug.Log("Changed to prologue");
        SceneManager.LoadScene("Prologue");
    }
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }
}
