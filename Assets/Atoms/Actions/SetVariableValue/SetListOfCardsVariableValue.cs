using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `ListOfCards`. Inherits from `SetVariableValue&lt;ListOfCards, ListOfCardsPair, ListOfCardsVariable, ListOfCardsConstant, ListOfCardsReference, ListOfCardsEvent, ListOfCardsPairEvent, ListOfCardsVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ListOfCards", fileName = "SetListOfCardsVariableValue")]
    public sealed class SetListOfCardsVariableValue : SetVariableValue<
        ListOfCards,
        ListOfCardsPair,
        ListOfCardsVariable,
        ListOfCardsConstant,
        ListOfCardsReference,
        ListOfCardsEvent,
        ListOfCardsPairEvent,
        ListOfCardsListOfCardsFunction,
        ListOfCardsVariableInstancer>
    { }
}
