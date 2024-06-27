#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ListOfCardsPair`. Inherits from `AtomEventEditor&lt;ListOfCardsPair, ListOfCardsPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ListOfCardsPairEvent))]
    public sealed class ListOfCardsPairEventEditor : AtomEventEditor<ListOfCardsPair, ListOfCardsPairEvent> { }
}
#endif
