using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class FollowPlayerX : MonoBehaviour
   {
      Vector3 offset = new Vector3(26.5f, 0, 10f);

      [SerializeField] GameObject plane;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         transform.position = plane.transform.position + offset;
      }
   }
}
