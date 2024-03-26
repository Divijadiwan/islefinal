using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour 
//if you want to create another scene transition, 
//name the script with different name 
//e.g. SceneChanger1, SceneChanger2 or other name your like to put   
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Inside"); // "" < add your new scene name
           
        }

    }
    
}

