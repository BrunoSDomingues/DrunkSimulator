using UnityEngine;

public class WorldGenerator : MonoBehaviour {
    [SerializeField]
    private GameObject section;

    [SerializeField]
    private GameObject street;

    void Generate(int roads) {
        float z = street.GetComponent<MeshRenderer>().bounds.size.z;
        float pos = z;
        for (int i = 0; i < roads; i++) {
            Instantiate(section, new Vector3(0, 0, pos), Quaternion.identity);
            pos += z;
        }
    }
    void Start() {
        Generate(10);
    }
}
