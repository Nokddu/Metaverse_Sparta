using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    bool isOnBoard = false;

    public void Start()
    {
    }

    public void IsBoarding()
    {
        isOnBoard = !isOnBoard;

        gameObject.SetActive(isOnBoard);
    }
   

    public bool IsOnBoard()
    {
        return isOnBoard;
    }
}
