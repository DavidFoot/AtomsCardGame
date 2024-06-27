#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `CardObject`. Inherits from `AtomDrawer&lt;CardObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardObjectConstant))]
    public class CardObjectConstantDrawer : VariableDrawer<CardObjectConstant> { }
}
#endif
