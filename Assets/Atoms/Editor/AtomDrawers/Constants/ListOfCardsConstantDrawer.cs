#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `ListOfCards`. Inherits from `AtomDrawer&lt;ListOfCardsConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ListOfCardsConstant))]
    public class ListOfCardsConstantDrawer : VariableDrawer<ListOfCardsConstant> { }
}
#endif
