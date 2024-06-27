using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `CardObject`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CardObjectVariable))]
    public sealed class CardObjectVariableEditor : AtomVariableEditor<CardObject, CardObjectPair> { }
}
