using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        float speed = 35.0f;
        float turnSpeed = 100.0f;
        float wheelRadius = 0.5f;
        float horizontalInput = 0.0f;
        float forwardInput = 0.0f;

        Rigidbody rb = default;

        #region Wheels
        Transform[] wheels = new Transform[4];
        #endregion

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            GetVehicleWheels();
        }

        // Update is called once per frame
        void Update()
        {
            // Read input (old system)
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
        }

        void FixedUpdate()
        {
            // Calculate force to move vehicle forward
            var force = Vector3.forward * Time.fixedDeltaTime * speed * forwardInput;

            // Move the vehicle forward
            transform.Translate(force);
            // Rotate left or right
            transform.Rotate(Vector3.up, turnSpeed * Time.fixedDeltaTime * horizontalInput);

            // Spin wheels
            float distanceTraveled = speed * Time.fixedDeltaTime;
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
            if (forwardInput > 0.05)
            {
                wheels[0].Rotate(rotationDegree, 0, 0);
                wheels[1].Rotate(rotationDegree, 0, 0);
                wheels[2].Rotate(rotationDegree, 0, 0);
                wheels[3].Rotate(rotationDegree, 0, 0);
            }
        }
    }
}