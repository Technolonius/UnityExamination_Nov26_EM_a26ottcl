using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationDetector : MonoBehaviour
{
    public InputActionAsset inputAsset;
    
    public SpriteRenderer spriteRenderer;
    
    public Rigidbody2D rb;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        float horizontalVelocity = Mathf.Abs(rb.linearVelocity.x);
        float verticalVelocity = Mathf.Abs(rb.linearVelocity.y);

        
        anim.SetFloat("VelX", horizontalVelocity);
        anim.SetFloat("VelY", verticalVelocity);
        
        if (horizontalVelocity > 0.1 || horizontalVelocity < -0.1)
        {
            anim.SetBool("isWalking", true);
        }
        else if (horizontalVelocity < 0.1 || horizontalVelocity > -0.1)
        {
            anim.SetBool("isWalking", false);
        }

        if (verticalVelocity > 2)
        {
            anim.SetBool("isJumping", true);
        }
        else  if (verticalVelocity < 0.1)
        {
            anim.SetBool("isJumping", false);
        }

        if (horizontalVelocity > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalVelocity < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
