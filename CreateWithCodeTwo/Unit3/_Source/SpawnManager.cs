using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   [SerializeField] private GameObject _spawnPrefab;
   [SerializeField] private Transform _spawnContainer;
   [SerializeField] private float _delayAmount = 3.0f; 
   [SerializeField] private FarmerMovement _playerReff;

   private void Start()
   {
      InvokeRepeating("SpawnThang",2,_delayAmount);      
      GameObject.Find("Player").GetComponent<FarmerMovement>();//Find the component Player in the scene higharchy and get their component of tpy efarmermovement
   }
   
   public void SpawnThang()
   {
      
      if (_playerReff._bIsGameOver)
      {
         return;
      }
      //Instantiate(Object original, Vector3 position, Quaternion rotation)
      GameObject spawnedObject = Instantiate(_spawnPrefab, _spawnContainer.position, _spawnContainer.rotation);
      Debug.Log("spawned thang");
      //Removed the line that destroyed the object after delayAmount seconds
   }
}

