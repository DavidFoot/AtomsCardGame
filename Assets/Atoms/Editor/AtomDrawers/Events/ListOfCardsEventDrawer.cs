#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ListOfCards`. Inherits from `AtomDrawer&lt;ListOfCardsEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ListOfCardsEvent))]
    public class ListOfCardsEventDrawer : AtomDrawer<ListOfCardsEvent> { }
}
#endif
