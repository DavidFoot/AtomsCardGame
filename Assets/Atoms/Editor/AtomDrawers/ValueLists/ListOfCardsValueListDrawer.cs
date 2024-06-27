#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `ListOfCards`. Inherits from `AtomDrawer&lt;ListOfCardsValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ListOfCardsValueList))]
    public class ListOfCardsValueListDrawer : AtomDrawer<ListOfCardsValueList> { }
}
#endif
