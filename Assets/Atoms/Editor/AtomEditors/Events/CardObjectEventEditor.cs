#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CardObject`. Inherits from `AtomEventEditor&lt;CardObject, CardObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CardObjectEvent))]
    public sealed class CardObjectEventEditor : AtomEventEditor<CardObject, CardObjectEvent> { }
}
#endif
