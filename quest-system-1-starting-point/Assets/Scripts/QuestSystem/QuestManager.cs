using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private Dictionary <string, Quest> questMap;

    private void Awake()
    {
        questMap = CreateQuestMap();
        
    }

    private void OnEnable()
    {
        GameEventsManager.instance.questEvents.onStartQuest += StartQuest;
        GameEventsManager.instance.questEvents.onAdvanceQuest += AdvanceQuest;
        GameEventsManager.instance.questEvents.onFinishQuest += FinishQuest;
    }
    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onStartQuest -= StartQuest;
        GameEventsManager.instance.questEvents.onAdvanceQuest -= AdvanceQuest;
        GameEventsManager.instance.questEvents.onFinishQuest -= FinishQuest;
    }

    private void Start()
    {
        foreach(Quest quest in questMap.Values)
        {
            GameEventsManager.instance.questEvents.QuestStateChange(quest);
        }
    }

    private void StartQuest(string id)
    {

    }
    private void AdvanceQuest(string id)
    {
        
    }
    private void FinishQuest(string id)
    {
        
    }

    private Dictionary<string, Quest> CreateQuestMap()
        {
            QuestInfoSO[] allQuests = Resources.LoadAll<QuestInfoSO>("Quests");
            Dictionary<string, Quest> idToQuestMap = new Dictionary<string, Quest>();
            foreach (QuestInfoSO questInfo in allQuests)
            {
                if (idToQuestMap.ContainsKey(questInfo.id))
                {
                    Debug.LogWarning("Duplicate Id found when creating quest map:" + questInfo.id);
                }
                idToQuestMap.Add(questInfo.id, new Quest(questInfo));
            }
            return idToQuestMap;
        }
    private Quest GetQuestById(string id)
    {
    
        Quest quest = questMap[id];
        if (quest == null)
        {
            Debug.LogError("Id not found in the Quest Map: " + id);
        }
    
    return quest;
    }
}
