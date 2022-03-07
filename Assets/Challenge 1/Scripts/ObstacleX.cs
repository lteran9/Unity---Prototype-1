using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class ObstacleX : MonoBehaviour
   {
      [SerializeField] GameManagerX _gameManager = default;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }

      void LateUpdate()
      {
         if ((transform.position.z - _gameManager.PlanePosition().z) < -55)
         {
            gameObject.SetActive(false);
         }
      }

      void OnCollisionEnter(Collision collision)
      {
         _gameManager.EndGame();
      }

      public void Reposition(Vector3 position)
      {
         transform.position = position;
         gameObject.SetActive(true);
      }
   }
}
