using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class DiscardCards : MonoBehaviour
{
    [SerializeField] GameObjectValueList hand;
    [SerializeField] GameObjectValueList deck;
    [SerializeField] GameObjectValueList selected;
    [SerializeField] GameObjectValueList discarded;


    [SerializeField] IntReference currentDeckCount;
    [SerializeField] IntReference currentDiscardCount;
    [SerializeField] IntReference currentSelectedCard;
    [SerializeField] IntReference maxCardDiscard;
    [SerializeField] GameObject discardedContainer;
    [SerializeField] GameObject handContainer;
    [SerializeField] Transform discardedPosition;
    [SerializeField] GameObjectEventReference onHandChange;
    public void ReplaceCard()
    {
        if (selected.Count > 0 && currentDiscardCount.Value > 0)
        {
            for(int i = 0; i< selected.Count; i++)
            {
                CardObject oldCard = selected[i].GetComponent<CardObject>();
                Debug.Log("cardId : " + oldCard.cardID.Value);
                Debug.Log("positioninhand : " + oldCard.positionInHand.Value);
                Vector2 placeToBe = selected[i].transform.position;
                selected[i].transform.parent = discardedContainer.transform;
                selected[i].transform.position = discardedPosition.position;
                int indexInHand = oldCard.positionInHand.Value;
                Debug.Log("index : " + indexInHand);
                hand[indexInHand] = deck[i];
                CardObject newCard = hand[indexInHand].GetComponent<CardObject>();
                newCard.positionInHand.Value = indexInHand;
                newCard.inHand.Value = true;
                hand[indexInHand].transform.parent = handContainer.transform;
                hand[indexInHand].transform.position = placeToBe;
                onHandChange.Event.Raise(newCard.gameObject);
                hand.Remove(selected[i]);
                deck.RemoveAt(i);
                oldCard.isCardSelected.Value = false;
                oldCard.inHand.Value = false;
                currentDeckCount.Value--;              
            }
            currentDiscardCount.Value--;
            currentSelectedCard.Value = 0;
            selected.Clear();
        }
        // remove selected cart from hand v 
        // clean selected List  v
        // deplacer la carte dans un autre parent + position + setactive ? 
        // pick x nouvelle cartes dans la pioche v 
        // ajouter a la hand sur les index libre 
        // remove from deck
        // raise un  eventinstancer Discard  sur la carte si possible ? 
        // placer les nouvelles cartes sur le jeu
    }
}
