using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class cardClicked : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ColorReference selectedColor;
    [SerializeField] ColorReference baseColor;
    [SerializeField] GameObject sprite;
    [SerializeField] IntReference maxDiscardCard;
    [SerializeField] IntReference currentSelectedCard;
    [SerializeField] BoolReference isCardSelected;  
    [SerializeField] GameObjectValueList selectedList;  

    public void CardClicked(bool isSelected)
    {
        if (!isSelected) {
            if (currentSelectedCard.Value < maxDiscardCard.Value)
            {
                sprite.GetComponent<SpriteRenderer>().material.color = selectedColor.Value;
                currentSelectedCard.Value++;
                isCardSelected.Value = true;
                selectedList.Add(GetComponentInParent<CardObject>().gameObject);
            }
            return;
        }
        sprite.GetComponent<SpriteRenderer>().material.color = baseColor.Value;
        currentSelectedCard.Value--;
        isCardSelected.Value = false;
        selectedList.Remove(GetComponentInParent<CardObject>().gameObject);
    }
}
