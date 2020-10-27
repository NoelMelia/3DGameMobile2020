using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    //use this to load level 1
    // to get the music to continue on the next level use DontDestroyON load
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstLevel", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadFirstLevel(){
        SceneManager.LoadScene(1);
    }
}
