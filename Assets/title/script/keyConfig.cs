using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class keyConfig : carsol
{

    // Start is called before the first frame update
    public override void Select()
    {
        
        
        StartCoroutine(Load_C_Scene());
    }
    IEnumerator Load_C_Scene()
    {
        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(0.2f);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("keyConfig");

        // ロードがまだなら次のフレームへ
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
