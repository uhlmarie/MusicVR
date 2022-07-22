using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangePianoLearning : MonoBehaviour
{
    [Tooltip("Interactable to which the press events are being routed. Defaults to the object of the component.")]
    public Interactable routingTarget;

    /// Enum specifying which button event causes a Click to be raised.
    public enum PhysicalPressEventBehavior
    {
        EventOnClickCompletion = 0,
        EventOnPress,
        EventOnTouch
    }
    public PhysicalPressEventBehavior InteractableOnClick = PhysicalPressEventBehavior.EventOnClickCompletion;

    private void Awake()
    {
        if (routingTarget == null)
        {
            routingTarget = GetComponent<Interactable>();
        }
    }

    public void OnHandPressTriggered()
    {
        SceneManager.LoadScene("piano_learning");
    }
}