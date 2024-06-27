#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ListOfCardsPair`. Inherits from `AtomDrawer&lt;ListOfCardsPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ListOfCardsPairEvent))]
    public class ListOfCardsPairEventDrawer : AtomDrawer<ListOfCardsPairEvent> { }
}
#endif
