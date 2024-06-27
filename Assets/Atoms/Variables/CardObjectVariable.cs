using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `CardObject`. Inherits from `AtomVariable&lt;CardObject, CardObjectPair, CardObjectEvent, CardObjectPairEvent, CardObjectCardObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/CardObject", fileName = "CardObjectVariable")]
    public sealed class CardObjectVariable : AtomVariable<CardObject, CardObjectPair, CardObjectEvent, CardObjectPairEvent, CardObjectCardObjectFunction>
    {
        protected override bool ValueEquals(CardObject other)
        {
            throw new NotImplementedException();
        }
    }
}
