using UnityEngine;

public abstract class QuestStep : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
private bool isFinished = false;

protected void FinishQuestStep ()
{
    if (!isFinished)
    {
        isFinished = true;
        //TODO - Advance the quest forward now that weve finished this step
        Destroy(this.gameObject);
    }
}

}
