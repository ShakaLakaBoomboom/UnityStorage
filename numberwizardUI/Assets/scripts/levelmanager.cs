using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour {

	public void LoadLevel(string levelName)
    {
        print("loading level" + levelName);
        SceneManager.LoadScene(levelName);

    }

    private void Start()
    {
        LoadLevel("Level 1");
    }
    public void Quit()
    {
        print("caw ja bicca peanut");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
