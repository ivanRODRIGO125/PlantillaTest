using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset_escenea : MonoBehaviour
{
    public void reset()
    {
        if (Input.GetKeyDown(KeyCode.R))
        
      { SceneManager.LoadScene("escena1");
            Debug.Log("el codigo anda");

        }



    }
}
