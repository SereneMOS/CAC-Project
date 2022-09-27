using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transition_time = 1f;
    
    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1)); 
    }
    
    
    IEnumerator LoadScene (int scene_index) {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transition_time);

        SceneManager.LoadScene(scene_index);
    }
    
}
    
