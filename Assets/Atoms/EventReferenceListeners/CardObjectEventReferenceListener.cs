using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CardObject`. Inherits from `AtomEventReferenceListener&lt;CardObject, CardObjectEvent, CardObjectEventReference, CardObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CardObject Event Reference Listener")]
    public sealed class CardObjectEventReferenceListener : AtomEventReferenceListener<
        CardObject,
        CardObjectEvent,
        CardObjectEventReference,
        CardObjectUnityEvent>
    { }
}
