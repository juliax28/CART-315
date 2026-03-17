using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private Dictionary <string, Quest> questMap;

    private void Awake()
    {
        questMap = CreateQuestMap();
        Quest quest = GetQuestById("CollectCoinsQuest");
        Debug.Log(quest.info.displayName);
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
