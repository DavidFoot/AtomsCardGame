using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;CardObject&gt;`. Inherits from `IPair&lt;CardObject&gt;`.
    /// </summary>
    [Serializable]
    public struct CardObjectPair : IPair<CardObject>
    {
        public CardObject Item1 { get => _item1; set => _item1 = value; }
        public CardObject Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private CardObject _item1;
        [SerializeField]
        private CardObject _item2;

        public void Deconstruct(out CardObject item1, out CardObject item2) { item1 = Item1; item2 = Item2; }
    }
}