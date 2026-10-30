using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
   public void ExitButton ()
   {
        Application.Quit();
        Debug.Log("Application closed");
   }

   public void GroundScene ()
   {
        SceneManager.LoadScene("GroundPlane");
   }

   public void MidAirScene()
   {
        SceneManager.LoadScene("MidAir");
   }

}
