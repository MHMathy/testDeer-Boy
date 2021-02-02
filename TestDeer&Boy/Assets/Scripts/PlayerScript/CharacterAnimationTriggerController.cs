using UnityEngine;
using UnityEngine.Events;

public class CharacterAnimationTriggerController : MonoBehaviour
{
    public UnityEvent idleTrigger;
    public UnityEvent walkTrigger;
    public UnityEvent runTrigger;
    public UnityEvent jumpInPlaceTrigger;
    public UnityEvent jumpDistanceTrigger;
    public UnityEvent turnBackTrigger;
    
    public void TriggerIdle()
    {
        idleTrigger.Invoke();
    }
    public void TriggerWalk()
    {
        walkTrigger.Invoke();
    }
    public void TriggerRun()
    {
        runTrigger.Invoke();
    }
    public void TriggerJumpInPlace()
    {
        jumpInPlaceTrigger.Invoke();
    }
    public void TriggerJumpDistance()
    {
        jumpDistanceTrigger.Invoke();
    }
    public void TriggerTurnBack()
    {
        turnBackTrigger.Invoke();
    }
}
