using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] string gameText;
    [SerializeField] State[] otherStates;

    // Start is called before the first frame update
    public string GetStateText()
    {
        return gameText;
    }

    // Update is called once per frame
    public State[] GetOtherStates()
    {
        return otherStates;
    }
}
