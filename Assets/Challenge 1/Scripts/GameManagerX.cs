using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1.Challenge1
{
   public class GameManagerX : MonoBehaviour
   {
      [SerializeField] PlayerControllerX _plane = default;

      // Start, Settings, Exit
      [SerializeField] Canvas _mainMenu = default;
      // Restart
      [SerializeField] Canvas _gameOver = default;

      bool isGameActive = default;

      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }

      public void StartGame()
      {
         isGameActive = true;
      }

      public void EndGame()
      {
         isGameActive = false;
      }

      public void ReloadGame()
      {

      }

      public void AdvanceGame()
      {
         _plane.DisableInput();
      }

      public bool IsGameActive()
      {
         return isGameActive;
      }
   }
}