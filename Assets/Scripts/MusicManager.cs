using UnityEngine;

// https://stackoverflow.com/questions/27911324/play-continuous-music-when-swapping-between-multiple-scene-in-unity3d
public class MusicManager : MonoBehaviour {
    [SerializeField]
    public AudioSource ambienceSource;
    [SerializeField]
    private AudioClip music;

    private static MusicManager _instance;

    public static MusicManager instance {

        get {
            if (_instance == null) {
                _instance = GameObject.FindObjectOfType<MusicManager>();

                //Tell unity not to destroy this object when loading a new scene!
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    void Awake() {
        if (_instance == null) {
            //If I am the first instance, make me the Singleton
            _instance = this;
            DontDestroyOnLoad(this);
            Play();
        } else {
            //If a Singleton already exists and you find
            //another reference in scene, destroy it!
            if (this != _instance) {
                Destroy(this.gameObject);
            } else {
                Play();
            }
        }
    }

    public void Play() {
        ambienceSource.loop = true;
        ambienceSource.clip = music;
        ambienceSource.Play();
    }
}
