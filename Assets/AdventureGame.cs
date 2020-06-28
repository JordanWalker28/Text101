using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;

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
