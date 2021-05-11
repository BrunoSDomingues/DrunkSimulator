using UnityEngine;

public class WorldGenerator : MonoBehaviour {
    [SerializeField]
    private GameObject section;

    [SerializeField]
    private GameObject street;

    [SerializeField]
    private GameObject house;

    private int nPrefabs = 10;


    void Generate(int roads) {
        float z = street.GetComponent<MeshRenderer>().bounds.size.z;
        float pos = z;
        for (int i = 0; i < roads; i++) {
            Instantiate(section, new Vector3(0, 0, pos), Quaternion.identity);
            pos += z;
        }
        Instantiate(house, new Vector3(16.6f, 6.2f, pos - z - 1), Quaternion.Euler(0, 180, 0));
    }
    void Start() => Generate(nPrefabs);
}
