using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CardObjectPair`. Inherits from `AtomEventReferenceListener&lt;CardObjectPair, CardObjectPairEvent, CardObjectPairEventReference, CardObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CardObjectPair Event Reference Listener")]
    public sealed class CardObjectPairEventReferenceListener : AtomEventReferenceListener<
        CardObjectPair,
        CardObjectPairEvent,
        CardObjectPairEventReference,
        CardObjectPairUnityEvent>
    { }
}
