using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        Invoke("LoadLevel", 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
}
