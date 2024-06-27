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
    public void ShowCardinfos(bool isInHand)
    {
        Debug.Log("ShowCardinfos");
        uiCardValue.transform.position = transform.position;
        uiCardValue.GetComponent<TextMeshPro>().text = cardValue.Value.ToString();    
    }
}
