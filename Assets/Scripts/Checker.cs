using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Checker : MonoBehaviour
{
    #region Declaration
    public bool CheckerClicked;
    public int clickedCollor;

    public int blockChecker;

    public Transform ClickedChecker;

    public Transform destroyChecker;

    public int winWhite;
    public int winBlack;

    public Text turnText;
    public bool surrenderOrNot;
    public TextMesh Winner;

    public List<Transform> WhiteHaveEat = new List<Transform>();
    public List<Transform> BlackHaveEat = new List<Transform>();

    public float turnWhite;
    public float turnBlack;

    public Transform[] WhiteCheckers = new Transform[12];
    public Transform[] BlackCheckers = new Transform[12];

    public Transform Quit;
    public Transform Restart;
    public Transform Back;

    #endregion
    void Start()
    {
        turnText.text = "White turn";
        CheckerClicked = false;
        clickedCollor = 0;
        winWhite = 0;
        winBlack = 0;
        turnWhite = 0f;
        turnBlack = 7f;
        Winner.gameObject.SetActive(false);
    }

    void Update()
    {

    }
}


