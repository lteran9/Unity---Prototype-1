using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class PlayerControllerX : MonoBehaviour
   {
      [SerializeField] float speed = default;
      [SerializeField] float rotationSpeed = default;
      [SerializeField] float verticalInput = default;

      [SerializeField] GameManagerX _gameManager = default;

      int rotationDirection = -1; // clockwise
      int rotationStep = 10;

      bool blockVerticalInput = false;

      Vector3 currentRotation, targetRotation;

      // Start is called before the first frame update
      void Start()
      {

      }

      void Update()
      {
         if (_gameManager?.IsGameActive() == true)
         {
            if (blockVerticalInput == false)
            {
               // get the user's vertical input
               verticalInput = Input.GetAxis("Vertical");
            }

            if (Input.GetKeyDown("space"))
            {
               blockVerticalInput = true;
               gameObject.transform.Rotate(0, 0, -90);
            }

            if (Input.GetKeyUp("space"))
            {
               gameObject.transform.Rotate(0, 0, 90);
               blockVerticalInput = false;
            }
         }
      }

      // Update is called once per frame
      void FixedUpdate()
      {
         if (_gameManager?.IsGameActive() == true)
         {
            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
         }
         else
         {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
         }
      }
   }
}
