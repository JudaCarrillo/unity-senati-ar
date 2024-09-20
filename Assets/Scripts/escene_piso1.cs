using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escene_piso1 : MonoBehaviour
{
  public string Inicio;

    void Start()
    {
        StartCoroutine(changeSceneAfterTime(5f));
        IEnumerator
        changeSceneAfterTime(float time){
            yield return new WaitForSeconds(time);
            SceneManager.LoadScene(1);
        }
    }
}
