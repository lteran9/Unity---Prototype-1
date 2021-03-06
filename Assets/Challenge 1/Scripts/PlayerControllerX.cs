﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class PlayerControllerX : MonoBehaviour
   {
      [SerializeField] float speed;
      [SerializeField] float rotationSpeed;
      [SerializeField] float verticalInput;

      // Start is called before the first frame update
      void Start()
      {

      }

      void Update()
      {
         // get the user's vertical input
         verticalInput = Input.GetAxis("Vertical");
      }

      // Update is called once per frame
      void FixedUpdate()
      {
         // move the plane forward at a constant rate
         transform.Translate(Vector3.forward * Time.deltaTime * speed);

         // tilt the plane up/down based on up/down arrow keys
         transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
      }
   }
}
