using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escena_piso2 : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(changeSceneAfterTime(5f));
        IEnumerator
        changeSceneAfterTime(float time){
            yield return new WaitForSeconds(time);
            SceneManager.LoadScene(2);
        }
    }
}
