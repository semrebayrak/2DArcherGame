using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionn : MonoBehaviour
{

    public bool gameover = false;

    public float health = 1f;
    int temp = 0;
    // Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {

       if (other.gameObject.tag != "arrow") { 


            health = health - 0.05f;
            healthbar.sizeNormalized = health;
            Destroy(other.gameObject);
            if (healthbar.sizeNormalized < 0.05f)
            {
                healthbar.sizeNormalized = 0;
                
                StartCoroutine(MyCoroutine());
               
            }


        }
        
      
    }

    IEnumerator MyCoroutine()
    {
        //This is a coroutine

        Time.timeScale = 0.00001f;
        yield return new WaitForSeconds(0.0000125f);    //Wait one frame

        SceneManager.LoadScene("Menu");
    }

}
