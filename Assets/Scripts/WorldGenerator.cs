using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour {
    [SerializeField]
    private GameObject section;

    [SerializeField]
    private GameObject street;

    void Start() {
        float z = street.GetComponent<MeshRenderer>().bounds.size.z;
        float pos = z;
        for (int i = 0; i < 10; i++) {
            Instantiate(section, new Vector3(0, 0, pos), Quaternion.identity);
            pos += z;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
