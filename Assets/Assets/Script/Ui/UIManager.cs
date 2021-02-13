using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
       get
        {
            if(_instance == null)
            {
                Debug.Log("Ui Manager is Null");
            }
            return _instance;
        }
    }
    public Text playergem;

    public void Openshop(int gemcount)
    {
        playergem.text = gemcount.ToString()+" G";
    }

    private void Awake()
    {
        _instance = this;
    }
}
