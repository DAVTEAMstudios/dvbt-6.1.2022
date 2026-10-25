using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene("LevelSelect");
   }

   public void OptionsMenu()
   {
       SceneManager.LoadScene("OptionsMenu");
   }

   public void Options()
   {
       SceneManager.LoadScene("OptionsMenu");
   }

   public void About()
   {
       SceneManager.LoadScene("AboutMenu");
   }

   public void Store()
   {
       SceneManager.LoadScene("StoreMenu");
   }

   public void QuitGame()
   {
       Application.Quit();
   }
}
