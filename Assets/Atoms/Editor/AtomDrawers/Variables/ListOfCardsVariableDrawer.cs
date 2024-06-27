#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `ListOfCards`. Inherits from `AtomDrawer&lt;ListOfCardsVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ListOfCardsVariable))]
    public class ListOfCardsVariableDrawer : VariableDrawer<ListOfCardsVariable> { }
}
#endif
