using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] State StartingState;

    State state;

    void Start()
    {
        state = StartingState;
        getStateStory();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for(int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
                getStateStory();
            }
        }
    }

    private void getStateStory()
    {
        textComponent.text = state.GetStateStory();
    }
}
