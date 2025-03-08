using UnityEngine;

public class CharcaterController : MonoBehaviour
{
    private CharacterController playerController;
    private Vector3 playerVelocity;
    private bool playerGrounded;
    private float playerSpeed = 7f;

    //private float playerJump = 2f;
   

    private void Start()
    {
        //To assign the playerController as the CharcaterController:
        playerController = gameObject.AddComponent<CharacterController>();
    }
    
    void Update()
    //To check whether the player is grounded?
    {
        playerGrounded = playerController.isGrounded;
        if (playerGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        
        //For Moving Left and Right deirections:
        Vector3 movementSides = new Vector3(Input.GetAxis ("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerController.Move (movementSides * playerSpeed * Time.deltaTime);
        
        /* This is one of the method I tried out to give vertcial movements seperately but couldnt able to figure it out.
         It would be helpful if I get some ideologies on executing this as I wished.*/
        //For Moving Straight and Back:
        // Vector3 moveStraightBack = new Vector3(Input.GetAxis("Vertical"), 0);
        // playerController.Move(moveStraightBack * playerSpeed * Time.deltaTime);
        
    }
}
