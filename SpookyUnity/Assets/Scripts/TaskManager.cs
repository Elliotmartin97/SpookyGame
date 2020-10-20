using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public class Tasks
    {
        public string taskName;
        public bool complete;
        public bool selected;
        public string className;
    }

    //use class name sting like this maybe??
   // System.Activator.CreateInstance(Type.GetType(namespace className));

    public List<Tasks> AvailableTasks;
    public List<Tasks> currentTasks;
    public List<Tasks> completedTasks;

    // Start is called before the first frame update
    void Start()
    {
        List<Tasks> AvailableTasks = new List<Tasks>();
        List<Tasks> currentTasks = new List<Tasks>();
        List<Tasks> completedTasks = new List<Tasks>();
    }

    public void CreateTask(string taskName, bool status, string className)
    {
        Tasks newTask = new Tasks();

        newTask.taskName = taskName;
        newTask.complete = status;
        newTask.className = className;
        AvailableTasks.Add(newTask);

    }

    public void SelectTask()
    {
        if (AvailableTasks.Count != 0)
        {
            int randomNumber = Random.Range(0, AvailableTasks.Count);
            currentTasks.Add(AvailableTasks[randomNumber]);
            AvailableTasks[randomNumber].selected = true;
            AvailableTasks.RemoveAt(randomNumber);
        }
    }


    public void TaskComplete(string taskName)
    {
        for(int i = 0; i < currentTasks.Count; i++)
        {
            if(currentTasks[i].taskName == taskName)
            {
                currentTasks[i].complete = true;
                currentTasks[i].selected = false;
                completedTasks.Add(currentTasks[i]);
                currentTasks.RemoveAt(i);
            }
        }
       
    }
}
