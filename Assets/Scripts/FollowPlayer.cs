using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
   public class FollowPlayer : MonoBehaviour
   {
      [Header("Player & Camera Options")]
      [SerializeField] GameObject player;
      [SerializeField] Vector3 offset = new Vector3(0, 5, -7);


      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         // Offset camera position behind player object
         transform.position = player.transform.position + offset;
      }
   }
}
