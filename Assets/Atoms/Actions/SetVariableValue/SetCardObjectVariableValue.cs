using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `CardObject`. Inherits from `SetVariableValue&lt;CardObject, CardObjectPair, CardObjectVariable, CardObjectConstant, CardObjectReference, CardObjectEvent, CardObjectPairEvent, CardObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/CardObject", fileName = "SetCardObjectVariableValue")]
    public sealed class SetCardObjectVariableValue : SetVariableValue<
        CardObject,
        CardObjectPair,
        CardObjectVariable,
        CardObjectConstant,
        CardObjectReference,
        CardObjectEvent,
        CardObjectPairEvent,
        CardObjectCardObjectFunction,
        CardObjectVariableInstancer>
    { }
}
