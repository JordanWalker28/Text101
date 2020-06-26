using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Welcome to the game";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
