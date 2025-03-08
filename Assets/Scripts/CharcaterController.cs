using UnityEngine;

public class CharcaterController : MonoBehaviour
{
    private CharacterController playerController;
    private Vector3 playerVelocity;
    private bool playerGrounded;
    private float playerSpeed = 7f;

    private float playerJump = 2f;
    private float playerGravity = -4f;

    private void Start()
    {
        playerController = gameObject.AddComponent<CharacterController>();
    }
    
    void Update()
    {
        playerGrounded = playerController.isGrounded;
        if (playerGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        
        //For Moving Left and Right deirections:
        Vector3 movement = new Vector3(Input.GetAxis ("Horizontal"), 0);
        playerController.Move (movement * playerSpeed * Time.deltaTime);
    }
}
