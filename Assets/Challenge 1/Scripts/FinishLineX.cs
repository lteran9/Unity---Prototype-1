using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class FinishLineX : MonoBehaviour
   {
      [SerializeField] GameManagerX _gameManager = default;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }

      void OnTriggerEnter(Collider other)
      {
         _gameManager.AdvanceGame();
      }
   }
}