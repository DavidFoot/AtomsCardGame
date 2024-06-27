using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `ListOfCards`. Inherits from `AtomEventInstancer&lt;ListOfCards, ListOfCardsEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ListOfCards Event Instancer")]
    public class ListOfCardsEventInstancer : AtomEventInstancer<ListOfCards, ListOfCardsEvent> { }
}
