using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ListOfCards`. Inherits from `AtomEventReferenceListener&lt;ListOfCards, ListOfCardsEvent, ListOfCardsEventReference, ListOfCardsUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ListOfCards Event Reference Listener")]
    public sealed class ListOfCardsEventReferenceListener : AtomEventReferenceListener<
        ListOfCards,
        ListOfCardsEvent,
        ListOfCardsEventReference,
        ListOfCardsUnityEvent>
    { }
}
