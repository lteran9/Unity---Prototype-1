using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
   public class PlayerController : MonoBehaviour
   {
      float speed = 35.0f;
      float turnSpeed = 100.0f;
      float wheelRadius = 0.5f;
      float horizontalInput = 0.0f;
      float forwardInput = 0.0f;

      #region Wheels
      Transform[] wheels = new Transform[4];
      #endregion

      // Start is called before the first frame update
      void Start()
      {
         GetVehicleWheels();
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

         float distanceTraveled = speed * Time.deltaTime;
         float rotationInRadians = distanceTraveled / wheelRadius;
         float rotationInDegrees = rotationInRadians * Mathf.Rad2Deg;
         SpinVehicleWheels(rotationInDegrees);
      }

      void GetVehicleWheels()
      {
         // There should only ever be 4 wheels
         Debug.Assert(transform.childCount == 4);

         for (int i = 0; i < transform.childCount; i++)
         {
            wheels[i] = transform.GetChild(i);
         }
      }

      void SpinVehicleWheels(float rotationDegree)
      {
         wheels[0].Rotate(rotationDegree, 0, 0);
         wheels[1].Rotate(rotationDegree, 0, 0);
         wheels[2].Rotate(rotationDegree, 0, 0);
         wheels[3].Rotate(rotationDegree, 0, 0);
      }
   }
}