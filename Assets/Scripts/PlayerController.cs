using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float baseSpeed = 1.0f;
    float gravity = 9.8f;

    GameObject playerCamera;
    float cameraRotation;


    CharacterController characterController;

    void Start() {
        characterController = GetComponent<CharacterController>();
        playerCamera = GameObject.Find("Main Camera");
        cameraRotation = 0.0f;

    }

    void MovementUpdate() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        float y = 0;
        if (!characterController.isGrounded) {
            y = -gravity;
        }
        Vector3 direction = new Vector3(x, y, z);
        characterController.Move(direction * baseSpeed * Time.deltaTime);
    }

    void CameraUpdate() {
        //Tratando movimentação do mouse
        float mouse_dX = Input.GetAxis("Mouse X");
        float mouse_dY = Input.GetAxis("Mouse Y");

        //Tratando a rotação da câmera
        cameraRotation += mouse_dY;
        Mathf.Clamp(cameraRotation, -75.0f, 75.0f);

        transform.Rotate(Vector3.up, mouse_dX);


        playerCamera.transform.localRotation = Quaternion.Euler(cameraRotation, 0.0f, 0.0f);
    }

    void Update() {
        MovementUpdate();
        CameraUpdate();
    }
}

