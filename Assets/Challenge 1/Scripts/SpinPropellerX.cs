using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class SpinPropellerX : MonoBehaviour
   {
      [SerializeField] char axis = 'z';
      [SerializeField] float spinSpeed = 1200f;

      [SerializeField] GameManagerX _gameManager = default;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         if (_gameManager?.IsGameActive() == true)
         {
            if (axis == 'z' || axis == 'Z')
            {
               transform.Rotate(Vector3.forward, Time.deltaTime * spinSpeed);
            }

            if (axis == 'x' || axis == 'X')
            {
               transform.Rotate(Vector3.right, Time.deltaTime * spinSpeed);
            }

            if (axis == 'y' || axis == 'Y')
            {
               transform.Rotate(Vector3.up, Time.deltaTime * spinSpeed);
            }
         }
      }
   }
}
