using UnityEngine;

/// <summary>
/// Get the Rigidbody component of the player
/// Do jump when space is pressed if player is on ground which is calculated through the rigid body and evalting the player into the air
/// </summary>


public class FarmerMovement : MonoBehaviour
{


    private Rigidbody _rb;
    private bool _bIsOnGround;
    private bool _bAmIDead = false;
    public bool _bIsGameOver; //used in movebackground
    private Animator _playerAnim;
    
    //vfx
    public ParticleSystem explosionVFX;
    public ParticleSystem dirtVFX;
    
    //sfx
    private AudioSource _playerAudioSource; //audio source component
    public AudioClip jumpSFX;
    public AudioClip crashSFX;
    
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _playerAnim = GetComponent<Animator>();
        dirtVFX.Play();

        //audio source requires setup to play SFX
        _playerAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && _bIsOnGround && !_bAmIDead)
        {
            dirtVFX.Stop();
           DoJump();
           //WOWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW ANIM COMMS
              _playerAnim.SetTrigger("Jump_trig"); //trigger the jump animation
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            dirtVFX.Play();
            Debug.Log("Can jump again");
        }
        else if(other.gameObject.CompareTag("Mob"))
        {
            _bIsGameOver = true;
            _bAmIDead = true;
            
            
            Debug.Log("game over");
            _playerAnim.SetBool("Death_b", true); //trigger the death animation
            explosionVFX.Play();
            dirtVFX.Stop();
            _playerAudioSource.PlayOneShot(crashSFX, 1.0f);
        }

        _bIsOnGround = true;
    }


    void DoJump()
    {
        _rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        _bIsOnGround = false; //player has jumped, so not on ground anymore
        _playerAudioSource.PlayOneShot(jumpSFX, 1.0f);
    }
}