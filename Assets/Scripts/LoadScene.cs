using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Animator trigger;
    public float timing = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadGame();
        }
    }

    public void LoadGame()
    {
        StartCoroutine(GameLoader(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator GameLoader(int buildIndexs)
    {
        trigger.SetTrigger("Start");
        yield return new WaitForSeconds(timing);
        SceneManager.LoadScene(buildIndexs);

        //for lvl loading async
        //AsyncOperation operation = SceneManager.LoadSceneAsync(buildIndexs);
        //while (!operation.isDone)
        //{
        //    Debug.Log(operation.progress);
        //}
    }
}
