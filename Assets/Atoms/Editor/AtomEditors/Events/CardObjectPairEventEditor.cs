#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CardObjectPair`. Inherits from `AtomEventEditor&lt;CardObjectPair, CardObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CardObjectPairEvent))]
    public sealed class CardObjectPairEventEditor : AtomEventEditor<CardObjectPair, CardObjectPairEvent> { }
}
#endif
