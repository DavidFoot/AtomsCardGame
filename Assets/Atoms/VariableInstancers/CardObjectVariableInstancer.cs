using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `CardObject`. Inherits from `AtomVariableInstancer&lt;CardObjectVariable, CardObjectPair, CardObject, CardObjectEvent, CardObjectPairEvent, CardObjectCardObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/CardObject Variable Instancer")]
    public class CardObjectVariableInstancer : AtomVariableInstancer<
        CardObjectVariable,
        CardObjectPair,
        CardObject,
        CardObjectEvent,
        CardObjectPairEvent,
        CardObjectCardObjectFunction>
    { }
}
