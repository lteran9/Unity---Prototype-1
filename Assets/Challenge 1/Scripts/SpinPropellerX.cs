using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class SpinPropellerX : MonoBehaviour
   {
      [SerializeField] float spinSpeed = 1200f;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         transform.Rotate(Vector3.forward, Time.deltaTime * spinSpeed);
      }
   }
}
