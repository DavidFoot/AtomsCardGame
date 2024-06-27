using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] IntReference currentDeckCount;
    [SerializeField] List<int> possibleValueCard;
    [SerializeField] GameObjectValueList deck3;
    [SerializeField] GameObject card;
    [SerializeField] GameObject DeckContainer;
    [SerializeField] VoidBaseEventReference enEndDeckBuilding;    
    
    public void CreateDeck( int maxCards)
    {
        deck3.Clear();
        for (int i = 0; i < maxCards; i++)
        {
            GameObject cardInstance = Instantiate(card, DeckContainer.transform);
            int rand = UnityEngine.Random.Range(0, possibleValueCard.Count);
            cardInstance.name = card.name;
            cardInstance.GetComponent<CardObject>().cardValue.Value = possibleValueCard[rand];
            deck3.Add(cardInstance);
        }
        enEndDeckBuilding.Event.Raise();
    }


    private void DebugAll()
    {
        //string deckJoined = String.Join(",", deck.ToArray());
        //string handJoined = String.Join(",", hand.ToArray());
        //string selectedJoined = String.Join(",", selected.ToArray());
        //string discardedJoined = String.Join(",", discarded.ToArray());
        //Debug.Log("Deck: " + deckJoined);
        //Debug.Log("Hand: " + handJoined);
        //Debug.Log("selected: " + selectedJoined);
        //Debug.Log("discarded: " + discardedJoined);
    }
}
