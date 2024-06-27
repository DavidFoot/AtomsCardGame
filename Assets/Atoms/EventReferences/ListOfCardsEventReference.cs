using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `ListOfCards`. Inherits from `AtomEventReference&lt;ListOfCards, ListOfCardsVariable, ListOfCardsEvent, ListOfCardsVariableInstancer, ListOfCardsEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ListOfCardsEventReference : AtomEventReference<
        ListOfCards,
        ListOfCardsVariable,
        ListOfCardsEvent,
        ListOfCardsVariableInstancer,
        ListOfCardsEventInstancer>, IGetEvent 
    { }
}
