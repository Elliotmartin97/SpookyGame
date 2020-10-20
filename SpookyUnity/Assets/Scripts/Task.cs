using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public enum Status
    {
        NotStarted,
        InProgress,
        Complete
    }

    Status currentStatus;
    string taskName;
    TaskManager taskManager;

    // Start is called before the first frame update
    void Start()
    {
        taskManager = FindObjectOfType<TaskManager>();

    }

    public void UpdateStatus(Status status)
    {
        currentStatus = status;
    }

    void CheckStatus()
    {
       if(currentStatus == Status.Complete)
        {
            taskManager.TaskComplete(taskName);
        }
    }
}
