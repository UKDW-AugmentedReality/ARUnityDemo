
using UnityEngine;

public class AnimatedPrompt : MonoBehaviour
{

    public enum InstructionUI
    {
        CrossPlatformFindAPlane,
        FindAFace,
        FindABody,
        FindAnImage,
        FindAnObject,
        ARKitCoachingOverlay,
        TapToPlace,
        None
    }

    [SerializeField] 
    InstructionUI instruction;

    [SerializeField]
    ARUXAnimationManager
    animationManager;
    bool isStarted;

    // Start is called before the first frame update
    void Start()
    {
        ShowInstructions();
        isStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        if (isStarted)
            ShowInstructions();
    }

    void OnDisable()
    {
        animationManager.FadeOffCurrentUI();
    }

    void ShowInstructions()
    {
        switch (instruction)
        {
            case InstructionUI.CrossPlatformFindAPlane:
                animationManager.
                ShowCrossPlatformFindAPlane();
                break;
            case InstructionUI.FindAFace:
                animationManager.ShowFindFace();
                break;
            case InstructionUI.FindABody:
                animationManager.ShowFindBody();
                break;
            case InstructionUI.FindAnImage:
                animationManager.ShowFindImage();
                break;
            case InstructionUI.FindAnObject:
                animationManager.ShowFindObject();
                break;
            case InstructionUI.TapToPlace:
                animationManager.ShowTapToPlace();
                break;
            default:
                Debug.LogError("instruction switch missing, " +
                    "please edit AnimatedPrompt.cs " + instruction);
                break;
        }
    }
}
