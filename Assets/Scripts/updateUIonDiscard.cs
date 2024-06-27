using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class updateUIonDiscard : MonoBehaviour
{
    [Header("---Defausse---")]
    [SerializeField] GameObject discardUiTxtObject;
    [SerializeField] IntReference currentDiscardCount;
    [SerializeField] IntReference maxDiscard;
    [SerializeField] String discardUiTxtLabel;
    TextMeshProUGUI discardUiTxtValue;
    [Header("---DeckInfos---")]
    [SerializeField] GameObject deckUiTxtObject;
    [SerializeField] IntReference currentDeckCountValue;
    [SerializeField] IntReference maxDeckCountValue;
    [SerializeField] String deckUiTxtLabel;
    TextMeshProUGUI deckUiTxtValue;

    [Header("---DeckInfos---")]
    [SerializeField] GameObject scoreTxtObject;
    [SerializeField] IntReference currentScoreCount;
    [SerializeField] String scoreUiTxtLabel;
    TextMeshProUGUI scoreUiTxtValue;
    // Start is called before the first frame update
    private void Awake()
    {
        currentDiscardCount.Value = maxDiscard.Value;
        discardUiTxtValue = discardUiTxtObject.GetComponent<TextMeshProUGUI>();
        discardUiTxtValue.text = discardUiTxtLabel + " " + maxDiscard.Value.ToString();
        

        deckUiTxtValue = deckUiTxtObject.GetComponent<TextMeshProUGUI>();
        deckUiTxtValue.text = deckUiTxtLabel + " " + maxDeckCountValue.Value.ToString();
        currentDeckCountValue.Value = maxDeckCountValue.Value;

        scoreUiTxtValue = scoreTxtObject.GetComponent<TextMeshProUGUI>();
        scoreUiTxtValue.text = scoreUiTxtLabel + " " + currentScoreCount.Value.ToString();
    }
    private void Update()
    {
        //Debug.Log(currentDiscardCount.Value);
    }
    public void RefreshDiscardCountIU(int x)
    {
        deckUiTxtValue = deckUiTxtObject.GetComponent<TextMeshProUGUI>();
        discardUiTxtValue = discardUiTxtObject.GetComponent<TextMeshProUGUI>();
        scoreUiTxtValue = scoreTxtObject.GetComponent<TextMeshProUGUI>();
        deckUiTxtValue.text = deckUiTxtLabel + " " + currentDeckCountValue.Value.ToString();
        discardUiTxtValue.text = discardUiTxtLabel + " " + currentDiscardCount.Value.ToString();
        scoreUiTxtValue.text = scoreUiTxtLabel + " " + currentScoreCount.Value.ToString();
    }
}
