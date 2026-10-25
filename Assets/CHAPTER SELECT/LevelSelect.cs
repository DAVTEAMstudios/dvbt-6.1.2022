using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
   public void PlayTutorial()
   {
       SceneManager.LoadScene("Tutorial");
   }

   public void Back()
   {
       SceneManager.LoadScene("MainMenu");
   }

   public void CH1LV1() 
   {
       SceneManager.LoadScene("CH1LEVEL1");
   }

   public void CH1LV2()
   {
       SceneManager.LoadScene("Ch1Lv2");
   }

   public void Ch1BOSS()
   {
       SceneManager.LoadScene("CH1LEVEL3BOSS");
   }

   public void Secret()
   {
       SceneManager.LoadScene("LevelTest");
   }

   public void Ch2lv1()
   {
       SceneManager.LoadScene("CH2LEVEl1");
   }

   public void Ch3lv1()
   {
       SceneManager.LoadScene("CH3LEVEL1");
   }
}

