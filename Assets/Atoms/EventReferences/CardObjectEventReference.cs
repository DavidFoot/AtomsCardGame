using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `CardObject`. Inherits from `AtomEventReference&lt;CardObject, CardObjectVariable, CardObjectEvent, CardObjectVariableInstancer, CardObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CardObjectEventReference : AtomEventReference<
        CardObject,
        CardObjectVariable,
        CardObjectEvent,
        CardObjectVariableInstancer,
        CardObjectEventInstancer>, IGetEvent 
    { }
}
