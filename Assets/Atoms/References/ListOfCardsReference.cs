using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `ListOfCards`. Inherits from `AtomReference&lt;ListOfCards, ListOfCardsPair, ListOfCardsConstant, ListOfCardsVariable, ListOfCardsEvent, ListOfCardsPairEvent, ListOfCardsListOfCardsFunction, ListOfCardsVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ListOfCardsReference : AtomReference<
        ListOfCards,
        ListOfCardsPair,
        ListOfCardsConstant,
        ListOfCardsVariable,
        ListOfCardsEvent,
        ListOfCardsPairEvent,
        ListOfCardsListOfCardsFunction,
        ListOfCardsVariableInstancer>, IEquatable<ListOfCardsReference>
    {
        public ListOfCardsReference() : base() { }
        public ListOfCardsReference(ListOfCards value) : base(value) { }
        public bool Equals(ListOfCardsReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ListOfCards other)
        {
            throw new NotImplementedException();
        }
    }
}
