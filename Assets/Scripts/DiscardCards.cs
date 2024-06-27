using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class DiscardCards : MonoBehaviour
{
    [Header("---Defausse---")]
    [SerializeField] IntReference currentDiscardCount;
    public void UpdateCounter(int i)
    {
        Debug.Log("DiscardCards");
        if(currentDiscardCount.Value > 0) currentDiscardCount.Value--;

    }
}
