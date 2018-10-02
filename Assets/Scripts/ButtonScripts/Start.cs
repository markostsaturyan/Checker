using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene("Checkers");
    }
	
}
