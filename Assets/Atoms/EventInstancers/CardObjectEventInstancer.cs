using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `CardObject`. Inherits from `AtomEventInstancer&lt;CardObject, CardObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CardObject Event Instancer")]
    public class CardObjectEventInstancer : AtomEventInstancer<CardObject, CardObjectEvent> { }
}
