﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> GoToPoints = new List<GameObject>();

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }


}