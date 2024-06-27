using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.U2D;


public class CardObject : MonoBehaviour
{
    [SerializeField] public IntReference cardValue;
    [SerializeField] public IntReference cardID;
    [SerializeField] public IntReference cardIDCounter;
    [SerializeField] public BoolReference inHand;
    [SerializeField] public ColorReference baseColor;
    [SerializeField] List<int> possibleValueCard;
    [SerializeField] VoidBaseEventReference  onInstantiate;
    [SerializeField] GameObject  cardBaseSprite;
    [SerializeField] public IntReference positionInHand;
    [SerializeField] public BoolReference isCardSelected;
    private void Awake()
    {
        cardIDCounter.Value++;
        cardID.Value = cardIDCounter.Value;
        int rand = UnityEngine.Random.Range(0, possibleValueCard.Count);
        cardValue.Value = possibleValueCard[rand];
        cardBaseSprite.GetComponent<SpriteRenderer>().material.color = baseColor.Value;
        onInstantiate.Event.Raise();
    }
}
