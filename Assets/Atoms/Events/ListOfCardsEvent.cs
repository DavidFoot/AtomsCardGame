using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `ListOfCards`. Inherits from `AtomEvent&lt;ListOfCards&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ListOfCards", fileName = "ListOfCardsEvent")]
    public sealed class ListOfCardsEvent : AtomEvent<ListOfCards>
    {
    }
}
