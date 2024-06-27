using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `ListOfCards`. Inherits from `UnityEvent&lt;ListOfCards&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ListOfCardsUnityEvent : UnityEvent<ListOfCards> { }
}
