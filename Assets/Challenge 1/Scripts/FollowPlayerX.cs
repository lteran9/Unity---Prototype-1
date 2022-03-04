using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class FollowPlayerX : MonoBehaviour
   {
      [SerializeField] bool _ignoreYAxis = default;
      [SerializeField] Vector3 _offset = new Vector3(26.5f, 0, 10f);
      [SerializeField] GameObject _plane = default;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
         if (_ignoreYAxis)
         {
            transform.position = new Vector3(_plane.transform.position.x, _offset.y, _plane.transform.position.z);
         }
         else
         {
            transform.position = _plane.transform.position + _offset;
         }
      }
   }
}
