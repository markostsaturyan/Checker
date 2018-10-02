using UnityEngine;
using System.Collections;

public class BlackCheckerController : MonoBehaviour
{

    private GameObject game;
    private Checker CheckerScript;

    void Start()
    {
        game = GameObject.Find("Camera");
        CheckerScript = game.GetComponent<Checker>();

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        if (CheckerScript.surrenderOrNot == true) return;
        if (CheckerScript.clickedCollor != 1) return;
        if (CheckerScript.blockChecker != 1)
        {
            if (CheckerScript.BlackHaveEat.Count != 0)
            {
                
                foreach (Transform check in CheckerScript.BlackHaveEat)
                {
                    if (check == this.GetComponentInParent<Transform>())
                    {
                        CheckerScript.ClickedChecker = check;                       
                        CheckerScript.CheckerClicked = true;
                        return;
                    }
                }
            }
            else
            {
                CheckerScript.CheckerClicked = true;
                CheckerScript.ClickedChecker = this.GetComponentInParent<Transform>();
            }
        }
    }
}
