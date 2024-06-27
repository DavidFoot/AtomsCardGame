using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class cardClicked : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Color selectedColor;
    [SerializeField] GameObject sprite;
    [SerializeField] IntReference maxDiscardCard;
    [SerializeField] IntReference currentSelectedCard;
    public void CardClicked()
    {
        if (currentSelectedCard.Value < maxDiscardCard.Value) {
            sprite.GetComponent<SpriteRenderer>().material.color = selectedColor;
            currentSelectedCard.Value++;
        }
    }
}
