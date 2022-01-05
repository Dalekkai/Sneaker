using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) 
    {
        //Debug.Log("collision!");
        switch(other.gameObject.tag)
        {
            case "Enemy":
                
                Respawn();
                break;
            case "Finish":
                Invoke("LoadNextLevel",0.5f);
                break;
        }
    }

    void Respawn()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);  
    }

    void  LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex +1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 1;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
