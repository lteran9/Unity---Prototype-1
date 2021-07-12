using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
   public class PlayerController : MonoBehaviour
   {
      float speed = 35.0f;
      float turnSpeed = 100.0f;
      float horizontalInput = 0.0f;
      float forwardInput = 0.0f;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         // Read input
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical");
      }

      void FixedUpdate()
      {
         // Move the vehicle forward
         transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
         transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
      }
   }
}