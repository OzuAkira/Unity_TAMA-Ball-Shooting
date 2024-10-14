using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : carsol
{
    // 決定されたときの動作
    public override void Select()
    {
        
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {

        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1);


        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("stage1");

        // ロードがまだなら次のフレームへ
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
