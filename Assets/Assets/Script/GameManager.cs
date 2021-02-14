using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("Game Manager Not Found");
            }

            return _instance;
        }
    }

    public bool HasKeyToCastle { get; set; }
    private void Awake()
    {
        _instance = this;
    }
}
