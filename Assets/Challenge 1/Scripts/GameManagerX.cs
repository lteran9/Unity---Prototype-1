using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerX : MonoBehaviour
{
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

   public bool IsGameActive()
   {
      return isGameActive;
   }
}
