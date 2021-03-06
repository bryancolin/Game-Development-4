﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + " : " + i);
        i++;
        SetGameObject();
    }

    void SetGameObject()
    {
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == UnityEngine.Random.Range(200, 250) ) 
        {
            gameObject.GetComponentInChildren<Renderer>().enabled = false;
        }
    }
}
