using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ListOfCardsPair`. Inherits from `AtomEventReferenceListener&lt;ListOfCardsPair, ListOfCardsPairEvent, ListOfCardsPairEventReference, ListOfCardsPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ListOfCardsPair Event Reference Listener")]
    public sealed class ListOfCardsPairEventReferenceListener : AtomEventReferenceListener<
        ListOfCardsPair,
        ListOfCardsPairEvent,
        ListOfCardsPairEventReference,
        ListOfCardsPairUnityEvent>
    { }
}
