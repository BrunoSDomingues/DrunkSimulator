using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu : MonoBehaviour {
    [SerializeField] AudioSource audiosrc;
    [SerializeField] Slider slider;


    public void Play() {
        Debug.Log("Changed to warning");
        SceneManager.LoadScene("Menu 1");
    }
    public void Quit() {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start() {
        slider.value = MusicManager.instance.ambienceSource.volume;
    }

    // Update is called once per frame
    void Update() { }

    public void VolumeSliderChanged() {
        MusicManager.instance.ambienceSource.volume = slider.value;
    }
}
