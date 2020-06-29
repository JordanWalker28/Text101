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
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            getStateStory();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            getStateStory();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
            getStateStory();
        }
        else if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void getStateStory()
    {
        textComponent.text = state.GetStateStory();
    }
}
