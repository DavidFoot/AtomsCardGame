using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `ListOfCards`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ListOfCardsVariable))]
    public sealed class ListOfCardsVariableEditor : AtomVariableEditor<ListOfCards, ListOfCardsPair> { }
}
