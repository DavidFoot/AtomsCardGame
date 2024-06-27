#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `CardObject`. Inherits from `AtomDrawer&lt;CardObjectValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardObjectValueList))]
    public class CardObjectValueListDrawer : AtomDrawer<CardObjectValueList> { }
}
#endif
