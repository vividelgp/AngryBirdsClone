using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    public int MaxNumberOfShots = 3;

    private int _usedNumberOfShots;

    private IconHandler _iconHandler;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        _iconHandler = FindObjectOfType<IconHandler>();
    }

    public void UseShot()
    {
        _usedNumberOfShots++;
        _iconHandler.UseShot(_usedNumberOfShots);     
    }

    public bool HasEnoughShots()
    {
        if (_usedNumberOfShots < MaxNumberOfShots)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
