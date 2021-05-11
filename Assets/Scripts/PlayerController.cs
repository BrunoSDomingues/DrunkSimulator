using UnityEngine;

public class PlayerController : MonoBehaviour {
    public bool paused = false;

    private float baseSpeed = 4f;
    private float gravity = 9.8f;

    private GameObject playerCamera;
    private float cameraRotation;
    private Animator animator;

    private CharacterController characterController;

    private void Start() {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        playerCamera = GameObject.Find("Main Camera");
        cameraRotation = 0.0f;
    }

    private void MovementUpdate() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float y = 0;
        if (!characterController.isGrounded)
            y = -gravity;

        // Walk to the left
        if (x < 0) {
            animator.SetBool("fWalk", false);
            animator.SetBool("bWalk", false);
            animator.SetBool("lWalk", true);
            animator.SetBool("rWalk", false);
        }
        // Walk to the right
        else if (x > 0) {
            animator.SetBool("fWalk", false);
            animator.SetBool("bWalk", false);
            animator.SetBool("lWalk", false);
            animator.SetBool("rWalk", true);
        } else if (x == 0) {
            // Walk forward
            if (z > 0) {
                animator.SetBool("fWalk", true);
                animator.SetBool("bWalk", false);
                animator.SetBool("lWalk", false);
                animator.SetBool("rWalk", false);
            }
            // Walk backwards
            else if (z < 0) {
                animator.SetBool("fWalk", false);
                animator.SetBool("bWalk", true);
                animator.SetBool("lWalk", false);
                animator.SetBool("rWalk", false);
            }
            // Idle
            else {
                animator.SetBool("fWalk", false);
                animator.SetBool("bWalk", false);
                animator.SetBool("lWalk", false);
                animator.SetBool("rWalk", false);
            }
        }

        Vector3 direction = new Vector3(x, 0, z);

        direction = playerCamera.transform.TransformDirection(direction);
        direction = direction * baseSpeed * Time.deltaTime;
        direction.y = y;

        characterController.Move(direction);
    }

    private void CameraUpdate() {
        if (paused)
            return;
        //Tratando movimentação do mouse
        float mouse_dX = Input.GetAxis("Mouse X");
        float mouse_dY = Input.GetAxis("Mouse Y");

        //Tratando a rotação da câmera
        cameraRotation -= mouse_dY;
        cameraRotation = Mathf.Clamp(cameraRotation, -75.0f, 75.0f);

        transform.Rotate(Vector3.up, mouse_dX);

        playerCamera.transform.localRotation = Quaternion.Euler(cameraRotation, 0.0f, 0.0f);
    }

    private void Update() {
        MovementUpdate();
        CameraUpdate();
    }
}