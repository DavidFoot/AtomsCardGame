using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] IntReference maxHand;
    [SerializeField] IntReference maxDeck;
    [SerializeField] IntEventReference onStart;
    public void onStartGame()
    {
        onStart.Event.Raise(maxDeck);
    }
}
