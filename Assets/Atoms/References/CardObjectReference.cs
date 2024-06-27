using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `CardObject`. Inherits from `AtomReference&lt;CardObject, CardObjectPair, CardObjectConstant, CardObjectVariable, CardObjectEvent, CardObjectPairEvent, CardObjectCardObjectFunction, CardObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CardObjectReference : AtomReference<
        CardObject,
        CardObjectPair,
        CardObjectConstant,
        CardObjectVariable,
        CardObjectEvent,
        CardObjectPairEvent,
        CardObjectCardObjectFunction,
        CardObjectVariableInstancer>, IEquatable<CardObjectReference>
    {
        public CardObjectReference() : base() { }
        public CardObjectReference(CardObject value) : base(value) { }
        public bool Equals(CardObjectReference other) { return base.Equals(other); }
        protected override bool ValueEquals(CardObject other)
        {
            throw new NotImplementedException();
        }
    }
}
