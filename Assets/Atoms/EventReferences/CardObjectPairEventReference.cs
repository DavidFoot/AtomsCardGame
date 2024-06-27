using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `CardObjectPair`. Inherits from `AtomEventReference&lt;CardObjectPair, CardObjectVariable, CardObjectPairEvent, CardObjectVariableInstancer, CardObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CardObjectPairEventReference : AtomEventReference<
        CardObjectPair,
        CardObjectVariable,
        CardObjectPairEvent,
        CardObjectVariableInstancer,
        CardObjectPairEventInstancer>, IGetEvent 
    { }
}
