using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `ListOfCards`. Inherits from `AtomValueList&lt;ListOfCards, ListOfCardsEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/ListOfCards", fileName = "ListOfCardsValueList")]
    public sealed class ListOfCardsValueList : AtomValueList<ListOfCards, ListOfCardsEvent> { }
}
