#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CardObject`. Inherits from `AtomDrawer&lt;CardObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardObjectEvent))]
    public class CardObjectEventDrawer : AtomDrawer<CardObjectEvent> { }
}
#endif
