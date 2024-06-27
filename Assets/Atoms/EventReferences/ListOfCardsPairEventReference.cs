using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `ListOfCardsPair`. Inherits from `AtomEventReference&lt;ListOfCardsPair, ListOfCardsVariable, ListOfCardsPairEvent, ListOfCardsVariableInstancer, ListOfCardsPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ListOfCardsPairEventReference : AtomEventReference<
        ListOfCardsPair,
        ListOfCardsVariable,
        ListOfCardsPairEvent,
        ListOfCardsVariableInstancer,
        ListOfCardsPairEventInstancer>, IGetEvent 
    { }
}
