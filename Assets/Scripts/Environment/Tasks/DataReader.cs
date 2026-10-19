using System;
using System.IO;
using UnityEngine;

namespace Environment.Tasks
{
    [CreateAssetMenu(fileName = "ReadDataTask", menuName = "Read Data Task")]

    [Serializable]
    public class EmployeeList
    {
        public Data[] employees;
    }

    [Serializable]
    public class Data
    {
        public string name;
        public int employeeId;
        public bool hasEngineRoomClearance;
        public string lastEntranceInEngineRoom;
        public string lastExitFromEngineRoom;
    }

    public class DataReader : Task
    {
        [SerializeField] string FileName;
        public EmployeeList PLEASEWORK;     //Change the name PERHAPS
        string Json;
        string FilePath;

        public override void Execute()
        {
            Read();
            Solve(Json);
        }

        public void Read()
        {
            FilePath = Path.Combine(Application.streamingAssetsPath, FileName);
            Debug.Log(FilePath);

            Json = File.ReadAllText(FilePath);
            Debug.Log(Json);
        }

        public string Solve(string MyString)
        {
            PLEASEWORK = new EmployeeList();
            JsonUtility.FromJsonOverwrite(MyString, PLEASEWORK);
            return MyString;
        }
    }
}
