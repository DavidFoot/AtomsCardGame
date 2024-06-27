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
            cardInstance.name = card.name;
            deck3.Add(cardInstance);
        }
        enEndDeckBuilding.Event.Raise();
    }
}
