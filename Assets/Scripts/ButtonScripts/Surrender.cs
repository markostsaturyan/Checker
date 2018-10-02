using UnityEngine;
using System.Collections;

public class Surrender : MonoBehaviour {

    public Checker CheckerScript;
	// Use this for initialization
	void Start () {
        CheckerScript = GameObject.Find("Camera").GetComponent<Checker>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseEnter()
    {
        this.GetComponent<Transform>().transform.Rotate(new Vector3(0, 0, 90));
    }
    void OnMouseExit()
    {
        this.GetComponent<Transform>().transform.Rotate(new Vector3(0, 0, -90));
    }
    void OnMouseDown()
    {
        CheckerScript.turnText.text = "White Win";
    }
}
