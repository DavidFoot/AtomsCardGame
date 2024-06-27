using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `ListOfCardsPair`. Inherits from `AtomEvent&lt;ListOfCardsPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ListOfCardsPair", fileName = "ListOfCardsPairEvent")]
    public sealed class ListOfCardsPairEvent : AtomEvent<ListOfCardsPair>
    {
    }
}
