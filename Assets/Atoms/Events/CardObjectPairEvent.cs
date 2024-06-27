using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `CardObjectPair`. Inherits from `AtomEvent&lt;CardObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CardObjectPair", fileName = "CardObjectPairEvent")]
    public sealed class CardObjectPairEvent : AtomEvent<CardObjectPair>
    {
    }
}
