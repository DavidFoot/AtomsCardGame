#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ListOfCards`. Inherits from `AtomEventEditor&lt;ListOfCards, ListOfCardsEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ListOfCardsEvent))]
    public sealed class ListOfCardsEventEditor : AtomEventEditor<ListOfCards, ListOfCardsEvent> { }
}
#endif
