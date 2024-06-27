using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;ListOfCards&gt;`. Inherits from `IPair&lt;ListOfCards&gt;`.
    /// </summary>
    [Serializable]
    public struct ListOfCardsPair : IPair<ListOfCards>
    {
        public ListOfCards Item1 { get => _item1; set => _item1 = value; }
        public ListOfCards Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ListOfCards _item1;
        [SerializeField]
        private ListOfCards _item2;

        public void Deconstruct(out ListOfCards item1, out ListOfCards item2) { item1 = Item1; item2 = Item2; }
    }
}