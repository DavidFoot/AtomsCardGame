using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class showCardInfoInHand : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject uiCardValue;
    [SerializeField] IntReference cardValue;
    [SerializeField] IntReference cardID;
    [SerializeField] BoolReference inHand;
    [SerializeField] IntReference positionInHand;
    [SerializeField] GameObjectValueList handList;
    public void ShowCardinfos(GameObject carte)
    {
        Debug.Log("ShowCardinfos");
        if (carte.GetComponent<CardObject>().cardID.Value == cardID.Value)
        {
            uiCardValue.transform.position = transform.position;
            uiCardValue.GetComponent<TextMeshPro>().text = cardValue.Value.ToString();
            positionInHand.Value = handList.IndexOf(carte);
            inHand.Value = true;
        }
        //inHand.Value = false;
        //positionInHand.Value = 0;
    }
}
