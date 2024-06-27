using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `ListOfCards`. Inherits from `AtomVariableInstancer&lt;ListOfCardsVariable, ListOfCardsPair, ListOfCards, ListOfCardsEvent, ListOfCardsPairEvent, ListOfCardsListOfCardsFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ListOfCards Variable Instancer")]
    public class ListOfCardsVariableInstancer : AtomVariableInstancer<
        ListOfCardsVariable,
        ListOfCardsPair,
        ListOfCards,
        ListOfCardsEvent,
        ListOfCardsPairEvent,
        ListOfCardsListOfCardsFunction>
    { }
}
