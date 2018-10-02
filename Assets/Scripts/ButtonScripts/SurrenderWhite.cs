using UnityEngine;
using System.Collections;

public class SurrenderWhite : MonoBehaviour
{
    private Checker CheckerScript;
    
    void Start()
    {
        CheckerScript = GameObject.Find("Camera").GetComponent<Checker>();
    }

    void OnMouseDown()
    {
        if (CheckerScript.surrenderOrNot != true)
        {
            CheckerScript.surrenderOrNot = true;
            CheckerScript.Winner.text = "Black Win";
            CheckerScript.Winner.gameObject.SetActive(true);
            CheckerScript.turnText.gameObject.SetActive(false);
            CheckerScript.Quit.transform.position = new Vector3(2.5f, 3.5f, -0.54f);
            CheckerScript.Back.transform.position = new Vector3(3.5f, 3.5f, -0.54f);
            CheckerScript.Restart.transform.position = new Vector3(4.5f, 3.5f, -0.54f);
            
        }
    }
}
