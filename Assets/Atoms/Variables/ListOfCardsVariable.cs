using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `ListOfCards`. Inherits from `AtomVariable&lt;ListOfCards, ListOfCardsPair, ListOfCardsEvent, ListOfCardsPairEvent, ListOfCardsListOfCardsFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ListOfCards", fileName = "ListOfCardsVariable")]
    public sealed class ListOfCardsVariable : AtomVariable<ListOfCards, ListOfCardsPair, ListOfCardsEvent, ListOfCardsPairEvent, ListOfCardsListOfCardsFunction>
    {
        protected override bool ValueEquals(ListOfCards other)
        {
            throw new NotImplementedException();
        }
    }
}
