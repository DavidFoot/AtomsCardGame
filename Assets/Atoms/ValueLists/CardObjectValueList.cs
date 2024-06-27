using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `CardObject`. Inherits from `AtomValueList&lt;CardObject, CardObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/CardObject", fileName = "CardObjectValueList")]
    public sealed class CardObjectValueList : AtomValueList<CardObject, CardObjectEvent> { }
}
