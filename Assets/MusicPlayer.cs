using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Awake();

        Invoke(nameof(LoadFirstScene), 5f);
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

   private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


}
