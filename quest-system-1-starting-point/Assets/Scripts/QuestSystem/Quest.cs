using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public QuestInfoSO info;
public QuestState state;
private int currentQuestStepIndex;

public Quest(QuestInfoSO questInfo)
{
    this.info = questInfo;
    this.state = QuestState.REQUIREMENTS_NOT_MET;
    this.currentQuestStepIndex = 0;
}

public void MoveToNextStep()
{
    currentQuestStepIndex++;

}

public bool CurrentStepExists()
{
    return (currentQuestStepIndex < info.questStepPrefabs.Length);

}

public void InstantiateCurrentQuestStep(Transform parentTransform)
{
    GameObject questStepPrefab = getCurrentQuestStepPrefab();
    if (questStepPrefab != null)
    {
        Object.Instantiate<GameObject>(questStepPrefab, parentTransform);
    }
}
private GameObject getCurrentQuestStepPrefab()
{
    GameObject questStepPrefab = null;
    if (CurrentStepExists())
    {
        questStepPrefab = info.questStepPrefabs[currentQuestStepIndex];
    }
    else 
    {
        Debug.LogWarning("TRIED TO GET Quest pr4efab, but stepIndex was out of range insidating that " +
        "there's no current step: QuestId = " + info.id + ", stepIndex =" + currentQuestStepIndex);
    }
    return questStepPrefab;
}

}
