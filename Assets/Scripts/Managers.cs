using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Managers : MonoBehaviour
{
    public Button level1btn;

    // Start is called before the first frame update
    void Start()
    {
        level1btn.onClick.AddListener(LoadLevel1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        Debug.Log("Level 1 Clicked");
        SceneManager.LoadScene(1);
        //SceneManager.UnloadScene(0);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void LoadLevel2()
    {
        Debug.Log("Level 2 Clicked");
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //add events for level1
        if (scene.buildIndex == 1)
        {
            //DontDestroyOnLoad(this.gameObject);
            //do something
        }
    }
}
