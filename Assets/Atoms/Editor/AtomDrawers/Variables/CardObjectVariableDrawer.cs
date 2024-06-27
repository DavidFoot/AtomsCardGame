#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `CardObject`. Inherits from `AtomDrawer&lt;CardObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardObjectVariable))]
    public class CardObjectVariableDrawer : VariableDrawer<CardObjectVariable> { }
}
#endif
