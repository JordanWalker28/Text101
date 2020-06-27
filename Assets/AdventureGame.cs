using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;
    [SerializeField] State Room1;
    [SerializeField] State Room2;

    State state;

    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();
    }

    void Update()
    {
        
    }
}
