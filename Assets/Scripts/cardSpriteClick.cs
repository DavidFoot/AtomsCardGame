using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class cardSpriteClick : MonoBehaviour
{
    [SerializeField] BoolEventInstancer cardClicked;
    [SerializeField] BoolReference isSelected;

    private void OnMouseDown()
    {
        
        cardClicked.Event.Raise(isSelected.Value);
    }
}
