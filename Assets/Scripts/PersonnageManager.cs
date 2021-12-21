using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class PersonnageManager
{
    public int perso = 0;

    public void Bokz()
    {
        perso = 1;
    }

    public void KK()
    {
        perso = 2;
    }

    public void Spagrat()
    {
        perso = 3;
    }

    public void Spagtor()
    {
        perso = 4;
        Debug.Log(perso);
    }
}
