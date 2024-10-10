using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScenes : MonoBehaviour
{
    private int _currentScene;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _currentScene++;
            _currentScene %= 5;
            SceneManager.LoadScene(_currentScene);
        }
    }
}
