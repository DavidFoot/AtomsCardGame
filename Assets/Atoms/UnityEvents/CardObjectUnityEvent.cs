using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `CardObject`. Inherits from `UnityEvent&lt;CardObject&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CardObjectUnityEvent : UnityEvent<CardObject> { }
}
