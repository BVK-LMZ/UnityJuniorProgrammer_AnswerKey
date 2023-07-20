using System.Collections;
using UnityEngine;

public class FarmerAttacks : MonoBehaviour
{
    private bool canAttack1 = true;  // Tracks if we can perform attack 1
    private bool canAttack2 = true;  // Tracks if we can perform attack 2

    private const float Attack1Cooldown = 1f;  // One second cooldown on attack one
    private const float Attack2Cooldown = 3f;  // Three seconds cooldown on attack two
    
    [SerializeField] public GameObject ProjectilePrefab;

    
    
    
    
    private void SpawnAutoDestroyingProjectile()
    {
        //Instantiate the projectile at the position and rotation of this transform
        //Destroy the instance of the prefab you just instantiated, not the prefab itself. 
        GameObject projectile = Instantiate(ProjectilePrefab, transform.position, transform.rotation);
        Destroy(projectile, 5f);  
    }

    
    
    // Attack one sends a debug log message
    public IEnumerator Attack1()
    {
        if (canAttack1)
        {
            Debug.Log("Attack1 triggered");
            SpawnAutoDestroyingProjectile();
            
            canAttack1 = false;
            yield return new WaitForSeconds(Attack1Cooldown);
            canAttack1 = true;
        }
    }

    // Attack two sends a debug log message
    public IEnumerator Attack2()
    {
        if (canAttack2)
        {
            Debug.Log("Attack2 triggered");
           
            SpawnAutoDestroyingProjectile();
            Invoke("SpawnAutoDestroyingProjectile",.3f);
            Invoke("SpawnAutoDestroyingProjectile",.6f);
            
            

            canAttack2 = false;
            yield return new WaitForSeconds(Attack2Cooldown);
            canAttack2 = true;
        }
        
    }



    
 

    private void Update()
    {
        // If left button is clicked, trigger Attack1
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Attack1());
        }
        
        // If right button is clicked, trigger Attack2
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(Attack2());
        }
    }
    
    
    
}