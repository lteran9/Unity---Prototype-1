using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
   public class PowerUpX : MonoBehaviour
   {
      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }

      void OnTriggerEnter(Collider collider)
      {
         Destroy(gameObject);
      }
   }
}