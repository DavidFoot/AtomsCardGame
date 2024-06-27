using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObjectValueList hand;
    [SerializeField] GameObjectValueList deck;
    [SerializeField] IntReference currentDeckCount;
    [SerializeField] IntReference handMaxCard;
    [SerializeField] GameObject handContainer;
    [SerializeField] Transform initialPosition;
    [SerializeField] float spaceBetweenCard;
    [SerializeField] VoidBaseEventReference onHandDisplayed;
    public void DisplayHand()
    {
        if (deck.Count == 0) return;
        Vector3 basePosition = initialPosition.transform.position;
        for (int i = 0; i < handMaxCard; i++)
        {
            Vector2 size = deck[i].GetComponent<BoxCollider2D>().bounds.size;
            float offset = (i * size.x) + (spaceBetweenCard*i) + spaceBetweenCard;
            deck[i].transform.parent = handContainer.transform;
            deck[i].transform.position = basePosition + new Vector3(offset, 0,0) ;
            deck[i].GetComponent<CardObject>().inHand.Value = true;
            hand.Add(deck[i]);
            deck.RemoveAt(i);
            currentDeckCount.Value--;
            
        }
    }
}
