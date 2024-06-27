using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `CardObject`. Inherits from `AtomEvent&lt;CardObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CardObject", fileName = "CardObjectEvent")]
    public sealed class CardObjectEvent : AtomEvent<CardObject>
    {
    }
}
