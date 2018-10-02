using UnityEngine;
using System.Collections;

public class BController : MonoBehaviour
{
    #region Declaration
    private GameObject game;
    private Checker CheckerScript;

    public int stepCount;
    public bool translated;

    public float deltaX;
    public float deltaY;

    public float mousePosX;
    public float mousePosY;

    public Transform clickedCube;
    #endregion

    void Start()
    {
        game = GameObject.Find("Camera");
        CheckerScript = game.GetComponent<Checker>();
        mousePosX = 1f;
        mousePosY = 1f;
        stepCount = 0;
        translated = false;

    }
    
    void Update()
    {
    }

    void WhiteEat()
    {   // Ստուգում են բոլոր սպիտակ քարերը ուտելու հնարավորություն ունեն թե ոչ
        for (int i = 0; i < 12; i++)
        {
            if (CheckerScript.WhiteCheckers[i].transform.localScale.x == 0.25)
            {
                #region Սովորական քար
                // Ստուգում են աջ կողմի վերևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.WhiteCheckers[i].transform.position.x + 1 == CheckerScript.BlackCheckers[j].transform.position.x
                        && CheckerScript.WhiteCheckers[i].transform.position.y + 1 == CheckerScript.BlackCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x + 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x + 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x + 2 == -1 || CheckerScript.WhiteCheckers[i].transform.position.y + 2 == -1
                                || CheckerScript.WhiteCheckers[i].transform.position.x + 2 == 8 || CheckerScript.WhiteCheckers[i].transform.position.y + 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.WhiteHaveEat.Add(CheckerScript.WhiteCheckers[i]);
                        }
                    }
                }
                // Ստուգում ենք ձախ կողմի վերևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.WhiteCheckers[i].transform.position.x - 1 == CheckerScript.BlackCheckers[j].transform.position.x
                        && CheckerScript.WhiteCheckers[i].transform.position.y + 1 == CheckerScript.BlackCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x - 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x - 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x - 2 == -1 || CheckerScript.WhiteCheckers[i].transform.position.y + 2 == -1
                                || CheckerScript.WhiteCheckers[i].transform.position.x - 2 == 8 || CheckerScript.WhiteCheckers[i].transform.position.y + 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.WhiteHaveEat.Add(CheckerScript.WhiteCheckers[i]);
                        }
                    }
                }
                // Ստուգում ենք աջ կողմի ներքևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.WhiteCheckers[i].transform.position.x + 1 == CheckerScript.BlackCheckers[j].transform.position.x
                        && CheckerScript.WhiteCheckers[i].transform.position.y - 1 == CheckerScript.BlackCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x + 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x + 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x + 2 == -1 || CheckerScript.WhiteCheckers[i].transform.position.y - 2 == -1
                                || CheckerScript.WhiteCheckers[i].transform.position.x + 2 == 8 || CheckerScript.WhiteCheckers[i].transform.position.y - 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.WhiteHaveEat.Add(CheckerScript.WhiteCheckers[i]);
                        }
                    }
                }
                // Ստուգում ենք ձախ կողմի ներքևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.WhiteCheckers[i].transform.position.x - 1 == CheckerScript.BlackCheckers[j].transform.position.x
                        && CheckerScript.WhiteCheckers[i].transform.position.y - 1 == CheckerScript.BlackCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x - 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x - 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.WhiteCheckers[i].transform.position.x - 2 == -1 || CheckerScript.WhiteCheckers[i].transform.position.y - 2 == -1
                                || CheckerScript.WhiteCheckers[i].transform.position.x - 2 == 8 || CheckerScript.WhiteCheckers[i].transform.position.y - 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.WhiteHaveEat.Add(CheckerScript.WhiteCheckers[i]);
                        }
                    }
                }
                #endregion Սովորական քար
            }
            else
            {
                #region Դամա
                float delta = 1;
                int block1 = 0;
                int block2 = 0;
                int block3 = 0;
                int block4 = 0;
                int eat = 0;
                while (delta != 8)
                {
                    // Ստուգում ենք աջ կողմի վերևը
                    if (block1 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x + delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                block1++;
                                break;
                            }
                            if (CheckerScript.WhiteCheckers[i].transform.position.x + delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.BlackCheckers[j].transform.position.x + 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y + 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x + 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y + 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x + 1 == -1 || CheckerScript.BlackCheckers[j].transform.position.y + 1 == -1
                                        || CheckerScript.BlackCheckers[j].transform.position.x + 1 == 8 || CheckerScript.BlackCheckers[j].transform.position.y + 1 == 8)
                                    {
                                        block1++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    // Ստուգում ենք աջ կողմի ներքևը
                    if (block2 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x + delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                block2++;
                                break;
                            }
                            if (CheckerScript.WhiteCheckers[i].transform.position.x + delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.BlackCheckers[j].transform.position.x + 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y - 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x + 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y - 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x + 1 == -1 || CheckerScript.BlackCheckers[j].transform.position.y - 1 == -1
                                        || CheckerScript.BlackCheckers[j].transform.position.x + 1 == 8 || CheckerScript.BlackCheckers[j].transform.position.y - 1 == 8)
                                    {
                                        block2++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    // Ստուգում ենք ձախ կողմի ներքևը
                    if (block3 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x - delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                block3++;
                                break;
                            }
                            if (CheckerScript.WhiteCheckers[i].transform.position.x - delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y - delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.BlackCheckers[j].transform.position.x - 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y - 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x - 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y - 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x - 1 == -1 || CheckerScript.BlackCheckers[j].transform.position.y - 1 == -1
                                        || CheckerScript.BlackCheckers[j].transform.position.x - 1 == 8 || CheckerScript.BlackCheckers[j].transform.position.y - 1 == 8)
                                    {
                                        block3++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    // Ստուգում ենք ձախ կողմի վերևը
                    if (block4 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.WhiteCheckers[i].transform.position.x - delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                block4++;
                                break;
                            }
                            if (CheckerScript.WhiteCheckers[i].transform.position.x - delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.WhiteCheckers[i].transform.position.y + delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.BlackCheckers[j].transform.position.x - 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y + 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x - 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.BlackCheckers[j].transform.position.y + 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.BlackCheckers[j].transform.position.x - 1 == -1 || CheckerScript.BlackCheckers[j].transform.position.y + 1 == -1
                                        || CheckerScript.BlackCheckers[j].transform.position.x - 1 == 8 || CheckerScript.BlackCheckers[j].transform.position.y + 1 == 8)
                                    {
                                        block4++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (block1 + block2 + block3 + block4 == 4 || eat != 0)
                    {
                        break;
                    }
                    else
                    {
                        delta++;
                    }
                }
                if (eat != 0)
                {
                    CheckerScript.WhiteHaveEat.Add(CheckerScript.WhiteCheckers[i]);
                }
                #endregion
            }
        }
    }

    void BlackEat()
    {   // Ստուգում են բոլոր սպիտակ քարերը ուտելու հնարավորություն ունեն թե ոչ        
        for (int i = 0; i < 12; i++)
        {
            if (CheckerScript.BlackCheckers[i].transform.localScale.x == 0.25)
            {
                #region Սովորական քար
                // Ստուգում են աջ կողմի վերևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.BlackCheckers[i].transform.position.x + 1 == CheckerScript.WhiteCheckers[j].transform.position.x
                        && CheckerScript.BlackCheckers[i].transform.position.y + 1 == CheckerScript.WhiteCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x + 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x + 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x + 2 == -1 || CheckerScript.BlackCheckers[i].transform.position.y + 2 == -1
                                || CheckerScript.BlackCheckers[i].transform.position.x + 2 == 8 || CheckerScript.BlackCheckers[i].transform.position.y + 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.BlackHaveEat.Add(CheckerScript.BlackCheckers[i]);
                        }
                    }
                }
                // Ստուգում ենք ձախ կողմի վերևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.BlackCheckers[i].transform.position.x - 1 == CheckerScript.WhiteCheckers[j].transform.position.x
                        && CheckerScript.BlackCheckers[i].transform.position.y + 1 == CheckerScript.WhiteCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x - 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x - 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x - 2 == -1 || CheckerScript.BlackCheckers[i].transform.position.y + 2 == -1
                                || CheckerScript.BlackCheckers[i].transform.position.x - 2 == 8 || CheckerScript.BlackCheckers[i].transform.position.y + 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.BlackHaveEat.Add(CheckerScript.BlackCheckers[i]);
                        }
                    }
                }
                // Ստուգում ենք աջ կողմի ներքևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.BlackCheckers[i].transform.position.x + 1 == CheckerScript.WhiteCheckers[j].transform.position.x
                        && CheckerScript.BlackCheckers[i].transform.position.y - 1 == CheckerScript.WhiteCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x + 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x + 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x + 2 == -1 || CheckerScript.BlackCheckers[i].transform.position.y - 2 == -1
                                || CheckerScript.BlackCheckers[i].transform.position.x + 2 == 8 || CheckerScript.BlackCheckers[i].transform.position.y - 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.BlackHaveEat.Add(CheckerScript.BlackCheckers[i]);
                        }
                    }
                }
                // Ստուգում ենք ձախ կողմի ներքևը
                for (int j = 0; j < 12; j++)
                {

                    if (CheckerScript.BlackCheckers[i].transform.position.x - 1 == CheckerScript.WhiteCheckers[j].transform.position.x
                        && CheckerScript.BlackCheckers[i].transform.position.y - 1 == CheckerScript.WhiteCheckers[j].transform.position.y)
                    {
                        int count = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x - 2 == CheckerScript.BlackCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - 2 == CheckerScript.BlackCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x - 2 == CheckerScript.WhiteCheckers[k].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - 2 == CheckerScript.WhiteCheckers[k].transform.position.y
                                || CheckerScript.BlackCheckers[i].transform.position.x - 2 == -1 || CheckerScript.BlackCheckers[i].transform.position.y - 2 == -1
                                || CheckerScript.BlackCheckers[i].transform.position.x - 2 == 8 || CheckerScript.BlackCheckers[i].transform.position.y - 2 == 8)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            CheckerScript.BlackHaveEat.Add(CheckerScript.BlackCheckers[i]);
                        }
                    }
                }
                #endregion Սովորական քար
            }
            else
            {
                #region Դամա
                float delta = 1;
                int block1 = 0;
                int block2 = 0;
                int block3 = 0;
                int block4 = 0;
                int eat = 0;
                while (delta != 8)
                {
                    // Ստուգում ենք աջ կողմի վերևը
                    if (block1 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x + delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                block1++;
                                break;
                            }
                            if (CheckerScript.BlackCheckers[i].transform.position.x + delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.WhiteCheckers[j].transform.position.x + 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y + 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x + 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y + 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x + 1 == -1 || CheckerScript.WhiteCheckers[j].transform.position.y + 1 == -1
                                        || CheckerScript.WhiteCheckers[j].transform.position.x + 1 == 8 || CheckerScript.WhiteCheckers[j].transform.position.y + 1 == 8)
                                    {
                                        block1++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    // Ստուգում ենք աջ կողմի ներքևը
                    if (block2 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x + delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                block2++;
                                break;
                            }
                            if (CheckerScript.BlackCheckers[i].transform.position.x + delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.WhiteCheckers[j].transform.position.x + 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y - 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x + 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y - 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x + 1 == -1 || CheckerScript.WhiteCheckers[j].transform.position.y - 1 == -1
                                        || CheckerScript.WhiteCheckers[j].transform.position.x + 1 == 8 || CheckerScript.WhiteCheckers[j].transform.position.y - 1 == 8)
                                    {
                                        block2++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    // Ստուգում ենք ձախ կողմի ներքևը
                    if (block3 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x - delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                block3++;
                                break;
                            }
                            if (CheckerScript.BlackCheckers[i].transform.position.x - delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y - delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.WhiteCheckers[j].transform.position.x - 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y - 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x - 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y - 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x - 1 == -1 || CheckerScript.WhiteCheckers[j].transform.position.y - 1 == -1
                                        || CheckerScript.WhiteCheckers[j].transform.position.x - 1 == 8 || CheckerScript.WhiteCheckers[j].transform.position.y - 1 == 8)
                                    {
                                        block3++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    // Ստուգում ենք ձախ կողմի վերևը
                    if (block4 != 1)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (CheckerScript.BlackCheckers[i].transform.position.x - delta == CheckerScript.BlackCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + delta == CheckerScript.BlackCheckers[j].transform.position.y)
                            {
                                block4++;
                                break;
                            }
                            if (CheckerScript.BlackCheckers[i].transform.position.x - delta == CheckerScript.WhiteCheckers[j].transform.position.x
                                && CheckerScript.BlackCheckers[i].transform.position.y + delta == CheckerScript.WhiteCheckers[j].transform.position.y)
                            {
                                eat++;
                                for (int k = 0; k < 12; k++)
                                {
                                    if (CheckerScript.WhiteCheckers[j].transform.position.x - 1 == CheckerScript.WhiteCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y + 1 == CheckerScript.WhiteCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x - 1 == CheckerScript.BlackCheckers[k].transform.position.x
                                        && CheckerScript.WhiteCheckers[j].transform.position.y + 1 == CheckerScript.BlackCheckers[k].transform.position.y
                                        || CheckerScript.WhiteCheckers[j].transform.position.x - 1 == -1 || CheckerScript.WhiteCheckers[j].transform.position.y + 1 == -1
                                        || CheckerScript.WhiteCheckers[j].transform.position.x - 1 == 8 || CheckerScript.WhiteCheckers[j].transform.position.y + 1 == 8)
                                    {
                                        block4++;
                                        eat--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (block1 + block2 + block3 + block4 == 4 || eat != 0)
                    {
                        break;
                    }
                    else
                    {
                        delta++;
                    }
                }
                if (eat != 0)
                {
                    CheckerScript.BlackHaveEat.Add(CheckerScript.BlackCheckers[i]);
                }
                #endregion
            }
        }
    }

    void OnMouseDown()
    {
        if (CheckerScript.CheckerClicked == true)
        {

            clickedCube = this.GetComponentInParent<Transform>();


            deltaX = clickedCube.transform.position.x - CheckerScript.ClickedChecker.transform.position.x;
            deltaY = clickedCube.transform.position.y - CheckerScript.ClickedChecker.transform.position.y;

            if (CheckerScript.ClickedChecker.transform.localScale.x == 0.25 && CheckerScript.ClickedChecker.transform.localScale.y == 0.25)
            {
                if (CheckerScript.clickedCollor == 0)
                {
                    #region Սովորական սպիտակ քար
                    // Քայլ սպիտակ քարով
                    // Մի վանդակ քայլ
                    if (CheckerScript.WhiteHaveEat.Count == 0)
                    {
                        if ((deltaX == 1 || deltaX == -1) && deltaY == 1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (clickedCube.transform.position.x == CheckerScript.WhiteCheckers[i].transform.position.x && clickedCube.transform.position.y == CheckerScript.WhiteCheckers[i].transform.position.y)
                                    return;
                                if (clickedCube.transform.position.x == CheckerScript.BlackCheckers[i].transform.position.x && clickedCube.transform.position.y == CheckerScript.BlackCheckers[i].transform.position.y)
                                    return;
                            }
                            CheckerScript.ClickedChecker.transform.Translate(new Vector3(deltaX, deltaY));
                            //GameObject.Find("Camera").GetComponent<Transform>().transform.Rotate(new Vector3(0, 0, 180));
                            CheckerScript.WhiteHaveEat.Clear();
                            BlackEat();
                            CheckerScript.clickedCollor = 1;
                            CheckerScript.CheckerClicked = false;
                            CheckerScript.turnText.text = "Black turn";
                            return;
                        }
                    }
                    // Քայլ սպիտակ քարով
                    // Երկու վանդակ քայլ ու սև քար ուտել    

                    if ((deltaX == 2 || deltaX == -2) && (deltaY == 2 || deltaY == -2))
                    {
                        if (deltaX < 0) mousePosX = -1;
                        if (deltaY < 0) mousePosY = -1;
                        // Ստուգում ենք հնարավոր է քայլը թե ոչ, այսինքն այն քարը որը պետք է ուտել սև է թե ոչ և վանդակը ազատ է թե ոչ
                        for (int i = 0; i < 12; i++)
                        {
                            if ((CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                               && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                               || (CheckerScript.ClickedChecker.transform.position.x + 2 * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                               && CheckerScript.ClickedChecker.transform.position.y + 2 * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                               || (CheckerScript.ClickedChecker.transform.position.x + 2 * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                               && CheckerScript.ClickedChecker.transform.position.y + 2 * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y))
                                return;
                        }

                        for (int i = 0; i < 12; i++)
                        {
                            if (CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.BlackCheckers[i].transform.position.y)
                            {
                                CheckerScript.ClickedChecker.transform.Translate(new Vector3(deltaX, deltaY));
                                CheckerScript.BlackCheckers[i].transform.position = new Vector2(-1.7f, CheckerScript.turnWhite);
                                CheckerScript.BlackCheckers[i].transform.Rotate(new Vector3(90, 0));
                                if (CheckerScript.winWhite != 11)
                                {
                                    CheckerScript.winWhite++;
                                }
                                else
                                {
                                    CheckerScript.surrenderOrNot = true;
                                    CheckerScript.Winner.text = "White Win";
                                    CheckerScript.Winner.gameObject.SetActive(true);
                                    CheckerScript.turnText.gameObject.SetActive(false);
                                    CheckerScript.ClickedChecker = null;
                                    CheckerScript.Quit.transform.position = new Vector3(2.5f, 3.5f, -0.54f);
                                    CheckerScript.Back.transform.position = new Vector3(3.5f, 3.5f, -0.54f);
                                    CheckerScript.Restart.transform.position = new Vector3(4.5f, 3.5f, -0.54f);
                                    return;
                                }
                                CheckerScript.turnWhite += 0.1f;
                                CheckerScript.blockChecker = 0;
                                translated = true;
                                break;
                            }
                        }
                        // Ուտելուց հետո ստուգում ենք էլի կա ուտելու քար թե ոչ, եթե ոչ հերթը փոխում ենք  //Քայլը արվել էր սպիտակներով
                        if (translated)
                        {
                            for (int j = 0; j < 12; j++)
                            {   // Ստուգում է տեղափոխվածի աջ կողմի վերևի վանդակը
                                if (CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.BlackCheckers[j].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.BlackCheckers[j].transform.position.y
                                    && CheckerScript.BlackCheckers[j].transform.position.x + mousePosX != -1 && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY != -1
                                    && CheckerScript.BlackCheckers[j].transform.position.x + mousePosX != 8 && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY != 8)
                                {
                                    for (int k = 0; k < 12; k++)
                                    {
                                        if (CheckerScript.BlackCheckers[j].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                            && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                            || CheckerScript.BlackCheckers[j].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                            && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                        {
                                            stepCount++;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    stepCount++;
                                }
                                // Ստւգում է աջ կողմի ներքևի վանդակը
                                if (CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.BlackCheckers[j].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y - mousePosY == CheckerScript.BlackCheckers[j].transform.position.y
                                    && CheckerScript.BlackCheckers[j].transform.position.x + mousePosX != -1 && CheckerScript.BlackCheckers[j].transform.position.y - mousePosY != -1
                                    && CheckerScript.BlackCheckers[j].transform.position.x + mousePosX != 8 && CheckerScript.BlackCheckers[j].transform.position.y - mousePosY != 8)
                                {
                                    for (int k = 0; k < 12; k++)
                                    {
                                        if (CheckerScript.BlackCheckers[j].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                            && CheckerScript.BlackCheckers[j].transform.position.y - mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                            || CheckerScript.BlackCheckers[j].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                            && CheckerScript.BlackCheckers[j].transform.position.y - mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                        {
                                            stepCount++;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    stepCount++;
                                }
                                // Ստուգում է ձախ կողմի վերևի վանդակը
                                if (CheckerScript.ClickedChecker.transform.position.x - mousePosX == CheckerScript.BlackCheckers[j].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.BlackCheckers[j].transform.position.y
                                    && CheckerScript.BlackCheckers[j].transform.position.x - mousePosX != -1 && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY != -1
                                    && CheckerScript.BlackCheckers[j].transform.position.x - mousePosX != 8 && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY != 8)
                                {
                                    for (int k = 0; k < 12; k++)
                                    {
                                        if (CheckerScript.BlackCheckers[j].transform.position.x - mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                            && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                            || CheckerScript.BlackCheckers[j].transform.position.x - mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                            && CheckerScript.BlackCheckers[j].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                        {
                                            stepCount++;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    stepCount++;
                                }
                            }
                            if (stepCount == 36)
                            {
                                //GameObject.Find("Camera").GetComponent<Transform>().transform.Rotate(new Vector3(0, 0, 180));
                                CheckerScript.WhiteHaveEat.Clear();
                                BlackEat();
                                CheckerScript.CheckerClicked = false;
                                CheckerScript.clickedCollor = 1;
                                CheckerScript.turnText.text = "Black turn";
                            }
                            else
                            {
                                CheckerScript.blockChecker = 1;
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    #region Սովորական սև քար
                    // Քայլ սև քարով
                    // Մի վանդակ քայլ
                    if (CheckerScript.BlackHaveEat.Count == 0)
                    {
                        if ((deltaX == 1 || deltaX == -1) && deltaY == -1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (clickedCube.transform.position.x == CheckerScript.WhiteCheckers[i].transform.position.x && clickedCube.transform.position.y == CheckerScript.WhiteCheckers[i].transform.position.y)
                                    return;
                                if (clickedCube.transform.position.x == CheckerScript.BlackCheckers[i].transform.position.x && clickedCube.transform.position.y == CheckerScript.BlackCheckers[i].transform.position.y)
                                    return;
                            }
                            CheckerScript.ClickedChecker.transform.Translate(new Vector3(deltaX, deltaY));
                            //GameObject.Find("Camera").GetComponent<Transform>().transform.Rotate(new Vector3(0, 0, 180));
                            CheckerScript.clickedCollor = 0;
                            CheckerScript.CheckerClicked = false;
                            CheckerScript.BlackHaveEat.Clear();
                            WhiteEat();
                            CheckerScript.turnText.text = "White turn";
                            return;
                        }
                    }
                    // Քայլ սև քարով
                    // Երկու վանդակ քայլ ու սև քար ուտել
                    if ((deltaX == 2 || deltaX == -2) && (deltaY == 2 || deltaY == -2))
                    {
                        if (deltaX < 0) mousePosX = -1;
                        if (deltaY < 0) mousePosY = -1;
                        // Ստուգում ենք հնարավոր է քայլը թե ոչ, այսինքն այն քարը որը պետք է ուտել սպիտակ է թե ոչ և վանդակը ազատ է թե ոչ
                        for (int i = 0; i < 12; i++)
                        {
                            if ((CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.BlackCheckers[i].transform.position.y)
                                || (CheckerScript.ClickedChecker.transform.position.x + 2 * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                && CheckerScript.ClickedChecker.transform.position.y + 2 * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                                || (CheckerScript.ClickedChecker.transform.position.x + 2 * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                && CheckerScript.ClickedChecker.transform.position.y + 2 * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y))
                                return;
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            if (CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                            {
                                CheckerScript.ClickedChecker.transform.Translate(new Vector3(deltaX, deltaY));
                                CheckerScript.WhiteCheckers[i].transform.position = new Vector2(8.7f, CheckerScript.turnBlack);
                                CheckerScript.WhiteCheckers[i].transform.Rotate(new Vector3(-90, 0));
                                if (CheckerScript.winBlack != 11)
                                {
                                    CheckerScript.winBlack++;
                                }
                                else
                                {
                                    CheckerScript.surrenderOrNot = true;
                                    CheckerScript.Winner.text = "Black Win";
                                    CheckerScript.Winner.gameObject.SetActive(true);
                                    CheckerScript.turnText.gameObject.SetActive(false);
                                    CheckerScript.ClickedChecker = null;
                                    CheckerScript.Quit.transform.position = new Vector3(2.5f, 3.5f, -0.54f);
                                    CheckerScript.Back.transform.position = new Vector3(3.5f, 3.5f, -0.54f);
                                    CheckerScript.Restart.transform.position = new Vector3(4.5f, 3.5f, -0.54f);
                                    return;
                                }
                                CheckerScript.turnBlack -= 0.1f;
                                CheckerScript.blockChecker = 0;
                                translated = true;
                                break;
                            }
                        }
                        // Ուտելուց հետո ստուգում ենք էլի կա ուտելու քար թե ոչ, եթե ոչ հերթը փոխում ենք  //Քայլը արվել էր սևերով
                        if (translated)
                        {
                            for (int j = 0; j < 12; j++)
                            {   // Ստուգում է տեղափոխվածի աջ կողմի վերևի վանդակը
                                if (CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.WhiteCheckers[j].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.WhiteCheckers[j].transform.position.y
                                    && CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX != -1 && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY != -1
                                    && CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX != 8 && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY != 8)
                                {
                                    for (int k = 0; k < 12; k++)
                                    {
                                        if (CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                            && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                            || CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                            && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                        {
                                            stepCount++;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    stepCount++;
                                }
                                // Ստւգում է աջ կողմի ներքևի վանդակը
                                if (CheckerScript.ClickedChecker.transform.position.x + mousePosX == CheckerScript.WhiteCheckers[j].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y - mousePosY == CheckerScript.WhiteCheckers[j].transform.position.y
                                    && CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX != -1 && CheckerScript.WhiteCheckers[j].transform.position.y - mousePosY != -1
                                    && CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX != 8 && CheckerScript.WhiteCheckers[j].transform.position.y - mousePosY != 8)
                                {
                                    for (int k = 0; k < 12; k++)
                                    {
                                        if (CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                            && CheckerScript.WhiteCheckers[j].transform.position.y - mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                            || CheckerScript.WhiteCheckers[j].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                            && CheckerScript.WhiteCheckers[j].transform.position.y - mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                        {
                                            stepCount++;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    stepCount++;
                                }
                                // Ստուգում է ձախ կողմի վերևի վանդակը
                                if (CheckerScript.ClickedChecker.transform.position.x - mousePosX == CheckerScript.WhiteCheckers[j].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + mousePosY == CheckerScript.WhiteCheckers[j].transform.position.y
                                    && CheckerScript.WhiteCheckers[j].transform.position.x - mousePosX != -1 && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY != -1
                                    && CheckerScript.WhiteCheckers[j].transform.position.x - mousePosX != 8 && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY != 8)
                                {
                                    for (int k = 0; k < 12; k++)
                                    {
                                        if (CheckerScript.WhiteCheckers[j].transform.position.x - mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                            && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                            || CheckerScript.WhiteCheckers[j].transform.position.x - mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                            && CheckerScript.WhiteCheckers[j].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                        {
                                            stepCount++;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    stepCount++;
                                }
                            }
                            if (stepCount == 36)
                            {
                                //GameObject.Find("Camera").GetComponent<Transform>().transform.Rotate(new Vector3(0, 0, 180));
                                CheckerScript.CheckerClicked = false;
                                CheckerScript.clickedCollor = 0;
                                CheckerScript.BlackHaveEat.Clear();
                                WhiteEat();
                                CheckerScript.turnText.text = "White turn";
                            }
                            else
                            {
                                CheckerScript.blockChecker = 1;
                            }
                        }
                    }
                    #endregion
                }
            }
            else //Դամա
            {
                
                if (Mathf.Abs(deltaX) != Mathf.Abs(deltaY)) return;
                
                if (CheckerScript.clickedCollor == 0)
                {
                    
                    #region Սպիտակ դամա
                    // Սպիտակ դամա
                    // Քայլ սպիտակ քարով
                    // Ստուգում ենք վանդակը ազատ է թե ոչ
                    for (int i = 0; i < 12; i++)
                    {
                        if (CheckerScript.ClickedChecker.transform.position.x + deltaX == CheckerScript.WhiteCheckers[i].transform.position.x
                            && CheckerScript.ClickedChecker.transform.position.y + deltaY == CheckerScript.WhiteCheckers[i].transform.position.y
                            || CheckerScript.ClickedChecker.transform.position.x + deltaX == CheckerScript.BlackCheckers[i].transform.position.x
                            && CheckerScript.ClickedChecker.transform.position.y + deltaY == CheckerScript.BlackCheckers[i].transform.position.y)
                        {                            
                            return;
                        }
                    }
                    
                    // Ստուգում ենք ճանապարհը ազատ է թե ոչ այսինքն սպիտակ քար կա թե ոչ
                    // Նաև սև քար կա ճանապարհին թե ոչ
                    if (deltaX < 0) mousePosX = -1f;
                    if (deltaY < 0) mousePosY = -1f;
                  
                    if (deltaX != 1)
                    {
                        float modulDeltaX = Mathf.Abs(deltaX);
                        float j = 1;
                        while (modulDeltaX != j)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x + j * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + j * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                                {
                                    return;
                                }
                                if (CheckerScript.ClickedChecker.transform.position.x + j * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + j * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y)
                                {
                                    float p = 1;
                                    while (j + p != modulDeltaX)
                                    {
                                        for (int k = 0; k < 12; k++)
                                            if (CheckerScript.BlackCheckers[i].transform.position.x + p * mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                               && CheckerScript.BlackCheckers[i].transform.position.y + p * mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                               || CheckerScript.BlackCheckers[i].transform.position.x + p * mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                               && CheckerScript.BlackCheckers[i].transform.position.y + p * mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                return;
                                            }
                                        p++;
                                    }
                                    CheckerScript.destroyChecker = CheckerScript.BlackCheckers[i];
                                    j = modulDeltaX - 1;
                                    break;
                                }
                            }
                            j++;
                        }
                    }
                    if (CheckerScript.blockChecker == 1 && CheckerScript.destroyChecker == null)
                    {
                        return;
                    }
                    
                    CheckerScript.ClickedChecker.transform.Translate(new Vector3(deltaX, deltaY));
                    if (CheckerScript.destroyChecker != null)
                    {
                        CheckerScript.destroyChecker.transform.position = new Vector3(-1.7f, CheckerScript.turnWhite);
                        CheckerScript.destroyChecker.transform.Rotate(new Vector3(90, 0));
                        if (CheckerScript.winWhite != 11)
                        {
                            CheckerScript.winWhite++;
                        }
                        else
                        {
                            CheckerScript.surrenderOrNot = true;
                            CheckerScript.Winner.text = "White Win";
                            CheckerScript.Winner.gameObject.SetActive(true);
                            CheckerScript.turnText.gameObject.SetActive(false);
                            CheckerScript.ClickedChecker = null;
                            CheckerScript.Quit.transform.position = new Vector3(2.5f, 3.5f, -0.54f);
                            CheckerScript.Back.transform.position = new Vector3(3.5f, 3.5f, -0.54f);
                            CheckerScript.Restart.transform.position = new Vector3(4.5f, 3.5f, -0.54f);
                            CheckerScript.destroyChecker = null;
                            return;
                        }
                        CheckerScript.turnWhite += 0.1f;
                        CheckerScript.destroyChecker = null;
                    }
                    else
                    {
                        CheckerScript.CheckerClicked = false;
                        CheckerScript.clickedCollor = 1;
                        CheckerScript.turnText.text = "Black turn";
                        CheckerScript.WhiteHaveEat.Clear();
                        BlackEat();
                        return;
                    }
                    // Ստուգում ենք կա էլի ուտելու քար թե ոչ
                    int okOrNot1 = 0;
                    int okOrNot2 = 0;
                    int okOrNot3 = 0;
                    int eat = 0;

                    float dx = 1;
                    while (dx != 8)
                    {
                        // Ստուգում ենք որ սահմաններից դուրս չգանք
                        if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == -1 || CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == 8
                        || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == -1 || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == 8)
                        {
                            okOrNot1++;
                        }
                        if (CheckerScript.ClickedChecker.transform.position.x - dx * mousePosX == -1 || CheckerScript.ClickedChecker.transform.position.x - dx * mousePosX == 8
                            || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == -1 || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == 8)
                        {
                            okOrNot2++;
                        }
                        if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == -1 || CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == 8
                            || CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == -1 || CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == 8)
                        {
                            okOrNot3++;
                        }

                        // Ստուգում ենք կա ուտելու սև քար թե ոչ
                        if (okOrNot1 != 1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                                {
                                    okOrNot1++;
                                    break;
                                }
                                else
                                {
                                    if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                        && CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y
                                        && CheckerScript.BlackCheckers[i].transform.position.x + mousePosX != -1 && CheckerScript.BlackCheckers[i].transform.position.x + mousePosX != 8
                                        && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY != -1 && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY != 8)
                                    {
                                        eat++;
                                        for (int k = 0; k < 12; k++)
                                        {
                                            if (CheckerScript.BlackCheckers[i].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                                && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                                || CheckerScript.BlackCheckers[i].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                                && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                eat--;
                                                okOrNot1++;
                                                i = 12;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (okOrNot2 != 1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x - dx * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                                {
                                    okOrNot2++;
                                    break;
                                }
                                else
                                {
                                    if (CheckerScript.ClickedChecker.transform.position.x - (dx * mousePosX) == CheckerScript.BlackCheckers[i].transform.position.x
                                        && CheckerScript.ClickedChecker.transform.position.y + (dx * mousePosY) == CheckerScript.BlackCheckers[i].transform.position.y
                                        && CheckerScript.BlackCheckers[i].transform.position.x - mousePosX != -1 && CheckerScript.BlackCheckers[i].transform.position.x - mousePosX != 8
                                        && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY != -1 && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY != 8)
                                    {
                                        eat++;
                                        for (int k = 0; k < 12; k++)
                                        {
                                            if (CheckerScript.BlackCheckers[i].transform.position.x - mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                                && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                                || CheckerScript.BlackCheckers[i].transform.position.x - mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                                && CheckerScript.BlackCheckers[i].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                eat--;
                                                okOrNot2++;
                                                i = 12;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (okOrNot3 != 1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                                {
                                    okOrNot3++;
                                    break;
                                }
                                else
                                {
                                    if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                        && CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y
                                        && CheckerScript.BlackCheckers[i].transform.position.x + mousePosX != -1 && CheckerScript.BlackCheckers[i].transform.position.x + mousePosX != 8
                                        && CheckerScript.BlackCheckers[i].transform.position.y - mousePosY != -1 && CheckerScript.BlackCheckers[i].transform.position.y - mousePosY != 8)
                                    {
                                        eat++;
                                        for (int k = 0; k < 12; k++)
                                        {
                                            if (CheckerScript.BlackCheckers[i].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                                && CheckerScript.BlackCheckers[i].transform.position.y - mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                                || CheckerScript.BlackCheckers[i].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                                && CheckerScript.BlackCheckers[i].transform.position.y - mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                eat--;
                                                okOrNot3++;
                                                i = 12;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (okOrNot1 + okOrNot2 + okOrNot3 == 3 || eat != 0)
                        {
                            break;
                        }
                        else
                        {
                            dx++;
                        }
                    }
                    if (eat == 0)
                    {
                        CheckerScript.CheckerClicked = false;
                        CheckerScript.clickedCollor = 1;
                        CheckerScript.turnText.text = "Black turn";
                        CheckerScript.blockChecker = 0;
                        CheckerScript.WhiteHaveEat.Clear();
                        BlackEat();
                    }
                    else
                    {
                        eat = 0;
                        CheckerScript.blockChecker = 1;
                    }
                    okOrNot1 = 0;
                    okOrNot2 = 0;
                    okOrNot3 = 0;
                    #endregion Սպիտակ դամա            
                }
                else
                {
                    #region Սև դամա
                    // Սև դամա 
                    // Ստուգում ենք վանդակը ազատ է թե ոչ
                    for (int i = 0; i < 12; i++)
                    {
                        if (CheckerScript.ClickedChecker.transform.position.x + deltaX == CheckerScript.WhiteCheckers[i].transform.position.x
                            && CheckerScript.ClickedChecker.transform.position.y + deltaY == CheckerScript.WhiteCheckers[i].transform.position.y
                            || CheckerScript.ClickedChecker.transform.position.x + deltaX == CheckerScript.BlackCheckers[i].transform.position.x
                            && CheckerScript.ClickedChecker.transform.position.y + deltaY == CheckerScript.BlackCheckers[i].transform.position.y)
                            return;
                    }
                    // Ստուգում ենք ճանապարհը ազատ է թե ոչ այսինքն սպիտակ քար կա թե ոչ
                    // Նաև սև քար կա ճանապարհին թե ոչ
                    if (deltaX < 0) mousePosX = -1f;
                    if (deltaY < 0) mousePosY = -1f;

                    if (deltaX != 1)
                    {
                        int modulDeltaX = (int)Mathf.Abs(deltaX);
                        float j = 1;
                        while (modulDeltaX != j)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x + j * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + j * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y)
                                    return;
                                if (CheckerScript.ClickedChecker.transform.position.x + j * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + j * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y)
                                {
                                    float p = 1;
                                    while (j + p != modulDeltaX)
                                    {
                                        for (int k = 0; k < 12; k++)
                                            if (CheckerScript.WhiteCheckers[i].transform.position.x + p * mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                               && CheckerScript.WhiteCheckers[i].transform.position.y + p * mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                               || CheckerScript.WhiteCheckers[i].transform.position.x + p * mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                               && CheckerScript.WhiteCheckers[i].transform.position.y + p * mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                return;
                                            }
                                        p++;
                                    }
                                    CheckerScript.destroyChecker = CheckerScript.WhiteCheckers[i];
                                    j = modulDeltaX - 1;
                                    break;
                                }
                            }
                            j++;
                        }
                    }
                    if (CheckerScript.blockChecker == 1 && CheckerScript.destroyChecker == null) return;

                    CheckerScript.ClickedChecker.transform.Translate(new Vector3(deltaX, deltaY));
                    if (CheckerScript.destroyChecker != null)
                    {
                        CheckerScript.destroyChecker.transform.position = new Vector3(8.7f, CheckerScript.turnBlack);
                        CheckerScript.destroyChecker.transform.Rotate(new Vector3(-90, 0));
                        if (CheckerScript.winBlack != 11)
                        {
                            CheckerScript.winBlack++;
                        }
                        else
                        {
                            CheckerScript.surrenderOrNot = true;
                            CheckerScript.Winner.text = "Black Win";
                            CheckerScript.Winner.gameObject.SetActive(true);
                            CheckerScript.turnText.gameObject.SetActive(false);
                            CheckerScript.ClickedChecker = null;
                            CheckerScript.Quit.transform.position = new Vector3(2.5f, 3.5f, -0.54f);
                            CheckerScript.Back.transform.position = new Vector3(3.5f, 3.5f, -0.54f);
                            CheckerScript.Restart.transform.position = new Vector3(4.5f, 3.5f, -0.54f);
                            CheckerScript.destroyChecker = null;
                            return;
                        }
                        CheckerScript.turnBlack += 0.1f;
                        CheckerScript.destroyChecker = null;
                    }
                    else
                    {
                        CheckerScript.CheckerClicked = false;
                        CheckerScript.clickedCollor = 0;
                        CheckerScript.turnText.text = "White turn";
                        CheckerScript.BlackHaveEat.Clear();
                        WhiteEat();
                        return;
                    }
                    // Ստուգում ենք կա էլի ուտելու քար թե ոչ
                    int okOrNot1 = 0;
                    int okOrNot2 = 0;
                    int okOrNot3 = 0;
                    int eat = 0;

                    float dx = 1;
                    while (dx != 8)
                    {
                        // Ստուգում ենք որ սահմաններից դուրս չգանք
                        if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == -1 || CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == 8
                        || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == -1 || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == 8)
                        {
                            okOrNot1++;
                        }
                        if (CheckerScript.ClickedChecker.transform.position.x - dx * mousePosX == -1 || CheckerScript.ClickedChecker.transform.position.x - dx * mousePosX == 8
                            || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == -1 || CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == 8)
                        {
                            okOrNot2++;
                        }
                        if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == -1 || CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == 8
                            || CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == -1 || CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == 8)
                        {
                            okOrNot3++;
                        }

                        // Ստուգում ենք կա ուտելու սև քար թե ոչ
                        if (okOrNot1 != 1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y)
                                {
                                    okOrNot1++;
                                    break;
                                }
                                else
                                {
                                    if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                        && CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y
                                        && CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX != -1 && CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX != 8
                                        && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY != -1 && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY != 8)
                                    {
                                        eat++;
                                        for (int k = 0; k < 12; k++)
                                        {
                                            if (CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                                && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                                || CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                                && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                eat--;
                                                okOrNot1++;
                                                i = 12;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (okOrNot2 != 1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x - dx * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y + dx * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y)
                                {
                                    okOrNot2++;
                                    break;
                                }
                                else
                                {
                                    if (CheckerScript.ClickedChecker.transform.position.x - (dx * mousePosX) == CheckerScript.WhiteCheckers[i].transform.position.x
                                        && CheckerScript.ClickedChecker.transform.position.y + (dx * mousePosY) == CheckerScript.WhiteCheckers[i].transform.position.y
                                        && CheckerScript.WhiteCheckers[i].transform.position.x - mousePosX != -1 && CheckerScript.WhiteCheckers[i].transform.position.x - mousePosX != 8
                                        && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY != -1 && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY != 8)
                                    {
                                        eat++;
                                        for (int k = 0; k < 12; k++)
                                        {
                                            if (CheckerScript.WhiteCheckers[i].transform.position.x - mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                                && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                                || CheckerScript.WhiteCheckers[i].transform.position.x - mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                                && CheckerScript.WhiteCheckers[i].transform.position.y + mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                eat--;
                                                okOrNot2++;
                                                i = 12;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (okOrNot3 != 1)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.BlackCheckers[i].transform.position.x
                                    && CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == CheckerScript.BlackCheckers[i].transform.position.y)
                                {
                                    okOrNot3++;
                                    break;
                                }
                                else
                                {
                                    if (CheckerScript.ClickedChecker.transform.position.x + dx * mousePosX == CheckerScript.WhiteCheckers[i].transform.position.x
                                        && CheckerScript.ClickedChecker.transform.position.y - dx * mousePosY == CheckerScript.WhiteCheckers[i].transform.position.y
                                        && CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX != -1 && CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX != 8
                                        && CheckerScript.WhiteCheckers[i].transform.position.y - mousePosY != -1 && CheckerScript.WhiteCheckers[i].transform.position.y - mousePosY != 8)
                                    {
                                        eat++;
                                        for (int k = 0; k < 12; k++)
                                        {
                                            if (CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX == CheckerScript.BlackCheckers[k].transform.position.x
                                                && CheckerScript.WhiteCheckers[i].transform.position.y - mousePosY == CheckerScript.BlackCheckers[k].transform.position.y
                                                || CheckerScript.WhiteCheckers[i].transform.position.x + mousePosX == CheckerScript.WhiteCheckers[k].transform.position.x
                                                && CheckerScript.WhiteCheckers[i].transform.position.y - mousePosY == CheckerScript.WhiteCheckers[k].transform.position.y)
                                            {
                                                eat--;
                                                okOrNot3++;
                                                i = 12;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (okOrNot1 + okOrNot2 + okOrNot3 == 3 || eat != 0)
                        {
                            break;
                        }
                        else
                        {
                            dx++;
                        }
                    }
                    if (eat == 0)
                    {
                        CheckerScript.CheckerClicked = false;
                        CheckerScript.clickedCollor = 0;
                        CheckerScript.turnText.text = "White turn";
                        CheckerScript.blockChecker = 0;
                        CheckerScript.BlackHaveEat.Clear();
                        WhiteEat();
                    }
                    else
                    {
                        eat = 0;
                        CheckerScript.blockChecker = 1;
                    }
                    okOrNot1 = 0;
                    okOrNot2 = 0;
                    okOrNot3 = 0;
                    #endregion Սև դամա
                }
            }
        }
        mousePosX = 1;
        mousePosY = 1;
        stepCount = 0;
        translated = false;
        
    }
}